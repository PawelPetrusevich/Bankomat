using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public  class BANK
    {
        
       
        
        public   bool Autorization(string accountName,string password)
        {
            Console.WriteLine("Авторитизируйтесь");
            Console.WriteLine("Логин");
            string tempAccountName = Console.ReadLine();
            Console.WriteLine("Пароль");
            string tempPassword = Console.ReadLine();
            if (tempAccountName==accountName && tempPassword==password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
