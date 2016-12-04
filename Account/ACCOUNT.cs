using Bank;
using System;

namespace Account
{
    public class ACCOUNT:BANK
    {
        #region Поля
        private string accountName;
        private decimal balance;
        #endregion

        #region Свойства
        public string AccountName
        {
            get
            {
                return accountName;
            }

            set
            {
                accountName = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }
        #endregion
        /// <summary>
        /// Вывод баланса
        /// </summary>
        /// <returns></returns>
        public decimal ShowBalance()
        {
            return this.Balance;
        }

        /// <summary>
        /// пополнить баланс
        /// </summary>
        /// <param name="add"></param>
        public void AddBalance(decimal add)
        {
            Balance += add;
        }
        /// <summary>
        /// Снятие денег
        /// </summary>
        /// <param name="del"></param>
        public void DeleteBalance(decimal del)
        {
            if (Balance<del)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Недостаточно средств");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Balance = Balance - del;
                System.Console.WriteLine("Операция выполнена");
                Console.ResetColor();
            }
        }
        
    }
}
