using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AttractieCommunicatie
{
    static class Database
    {
        static internal MySqlConnection connection = new MySqlConnection();

        /*public string connectionString { get; set; }

        public Database(string connectionString)
        {
            connection.ConnectionString = connectionString;
        }*/

        static internal bool openConnection()
        {
            try 
            {
                connection.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        static internal bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        static public List<Account> getUsers()
        {
            string query = "SELECT * FROM solarcoasteruser";
            List<Account> accounts = new List<Account>();
            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Account account = new Account(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString());
                    accounts.Add(account);
                }

                dataReader.Close();
                closeConnection();
                return accounts;
            }
            return accounts;
        }

        static public bool updateDatabase(string _fieldName, string _value)
        {
            string query = "UPDATE solarcoasterstats SET " + _fieldName + " = '" + _value + "'";
            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            return false;
        }
    }
}
