using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    class Account
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private static string currentUser;

        public Account(int _id, string _name, string _password)
        {
            this.Id = _id; 
            this.Name = _name;
            this.Password = _password;
        } 

        public static bool authenticate(string _name, string _password)
        {
            bool returnValue = false;
            List<Account> accounts = Database.getUsers();

            foreach (Account account in accounts)
            {
                if (_name == account.Name && _password == account.Password)
                {
                    returnValue = true;
                    Account.currentUser = account.ToString();
                }
            }
            return returnValue;
        }

        public static string getCurrentUser()
        {
            return Account.currentUser;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
