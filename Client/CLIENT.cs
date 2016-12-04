using Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class CLIENT:ACCOUNT
    {
        #region Поля
        private string name;
        private string login;
        private string password;
        #endregion
        #region Свойства
        public string Login
        {
            get
            {
                return login;
            }

            private set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        #endregion

        
    }
}
