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

        static public bool testConnection()
        {
            //Bug waarbij de connection open wordt gezet terwijl het al open staat. Dit komt omdat deze functie op een timer staat.

            /*if (openConnection())
            {
                closeConnection();
                return true;
            }
            else
            {
                return false;
            }*/

            return true;
        }

        static public List<Account> getUsers()
        {
            string query = "SELECT id, name, password FROM solarcoasteruser";
            List<Account> accounts = new List<Account>();
            if (openConnection())
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

        static public bool updateSolarcoasterStats(string field, int value)
        {
            if (openConnection())
            {
                //Gebruik parameterized query om sql injectie te voorkomen
                string query = "UPDATE solarcoasterstats SET " + field + "=@value";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            return false;
        }

        static public bool updateSolarcoasterStats(string field, string value)
        {
            if (openConnection())
            {
                string query = "UPDATE solarcoasterstats SET " + field + "=@value";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            return false;
        }

        static public decimal getBatteryLevel()
        {
            decimal battery = 0;
            string query = "SELECT battery FROM solarcoasterstats";
            if (openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    battery = Convert.ToInt16(dataReader.GetValue(0));
                }

                dataReader.Close();
                closeConnection();
                return battery;
            }
            return battery;
        }
    }
}
