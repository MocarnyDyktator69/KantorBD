using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace KantorBD
{
    public class ExchangeRateUpdater
    {
        private DB db;

        public ExchangeRateUpdater()
        {
            db = new DB();
        }

        public void UpdateExchangeRates(Dictionary<string, decimal> rates, string fromCurrency)
        {
            using (db)
            {
                db.openConnection();

                foreach (var rate in rates)
                {
                    int fromCurrencyID = GetCurrencyID(fromCurrency);
                    int toCurrencyID = GetCurrencyID(rate.Key);

                    if (fromCurrencyID == 0 || toCurrencyID == 0)
                        continue;

                    UpdateRateInDatabase(fromCurrencyID, toCurrencyID, rate.Value);
                    SaveRateHistory(fromCurrencyID, toCurrencyID, rate.Value);
                }

                db.closeConnection();
            }
        }

        private int GetCurrencyID(string currencyCode)
        {
            string query = "SELECT currencyID FROM currency WHERE currencyCode = @currencyCode";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.AddWithValue("@currencyCode", currencyCode);

            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        private void UpdateRateInDatabase(int fromCurrencyID, int toCurrencyID, decimal rate)
        {
            string query = "UPDATE exchangerate SET rate = @rate, lastUpdated = NOW() WHERE fromCurrencyID = @fromCurrencyID AND toCurrencyID = @toCurrencyID";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.AddWithValue("@rate", rate);
            cmd.Parameters.AddWithValue("@fromCurrencyID", fromCurrencyID);
            cmd.Parameters.AddWithValue("@toCurrencyID", toCurrencyID);
            cmd.ExecuteNonQuery();
        }

        private void SaveRateHistory(int fromCurrencyID, int toCurrencyID, decimal rate)
        {
            string query = "INSERT INTO exchangeratehistory (fromCurrencyID, toCurrencyID, rate, updatedOn) VALUES (@fromCurrencyID, @toCurrencyID, @rate, NOW())";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.AddWithValue("@fromCurrencyID", fromCurrencyID);
            cmd.Parameters.AddWithValue("@toCurrencyID", toCurrencyID);
            cmd.Parameters.AddWithValue("@rate", rate);
            cmd.ExecuteNonQuery();
        }
    }
}
