namespace KantorBD
{
    internal static class Program
    {
        private static System.Threading.Timer timer; // Zmiana na System.Threading.Timer
        private static ExchangeRateService exchangeRateService = new ExchangeRateService();
        private static ExchangeRateParser exchangeRateParser = new ExchangeRateParser();
        private static ExchangeRateUpdater exchangeRateUpdater = new ExchangeRateUpdater();

        public static void Main2(string[] args)
        {
            Console.WriteLine("Press [Enter] to exit the program.");
            Console.ReadLine();
        }

        private static void StartAutomaticUpdates()
        {
            TimerCallback timerCallback = new TimerCallback(UpdateExchangeRates);
            // Uruchamia automatyczn¹ aktualizacjê co 10 minut
            timer = new System.Threading.Timer(timerCallback, null, 0, 600000); // 600000 ms = 10 minutes
        }

        private static async void UpdateExchangeRates(object state)
        {
            Console.WriteLine("Updating exchange rates...");

            try
            {
                string[] currencies = { "PLN", "EUR", "GBP", "USD" };
                foreach (var currency in currencies)
                {
                    string json = await exchangeRateService.GetExchangeRatesAsync(currency);
                    var rates = exchangeRateParser.ParseExchangeRates(json, currency);
                    exchangeRateUpdater.UpdateExchangeRates(rates, currency);
                }

                Console.WriteLine("Exchange rates updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating exchange rates: " + ex.Message);
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            StartAutomaticUpdates();
            Application.Run(new StartForm());
        }
    }
}