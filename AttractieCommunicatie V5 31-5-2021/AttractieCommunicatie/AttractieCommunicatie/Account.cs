using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Account(int _id, string _name, string _password)
        {
            this.Id = _id;
            this.Name = _name;
            this.Password = _password;
        } 

        public static bool logIn(string _name, string _password)
        {
            List<Account> accounts = Database.getUsers();

            foreach (Account account in accounts)
            {
                if (_name == account.Name && _password == account.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
