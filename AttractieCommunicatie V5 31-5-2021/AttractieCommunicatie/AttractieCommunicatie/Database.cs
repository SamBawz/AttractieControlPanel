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

        static internal bool OpenConnection()
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

        static internal bool CloseConnection()
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

        static public List<Account> GetUsers()
        {
            string query = "SELECT * FROM solarcoasteruser";

            //Create a list to store the result
            List<Account> accounts = new List<Account>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    //Add every user to a user object that will be stored in the users list
                    Account account = new Account(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString());
                    accounts.Add(account);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list
                return accounts;
            }
            return accounts;
        }

        static public bool UpdateDatabase(string _fieldName, int _value)
        {
            //password is hashed (sam)
            string query = "UPDATE solarcoasterstats SET " + _fieldName + " = '" + _value + "'";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
                return true;
            }
            return false;
        }

    }
}
