using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;



namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Устоновите логин и пороль");
            CLIENT NewClient = new CLIENT() { AccountName = Console.ReadLine(), Password = Console.ReadLine(),Balance=0 };
            
            //NewClient.AccountName = Console.ReadLine();
            //NewClient.Password = Console.ReadLine();
            while (NewClient.Autorization(NewClient.AccountName,NewClient.Password))
            {
                Console.WriteLine("Вход выполнен");
                bool x = true;
                while ( x)
                {
                    int a;
                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1.Показать баланс");
                    Console.WriteLine("2.Паполнить баланс");
                    Console.WriteLine("3.Снять деньги");
                    Console.WriteLine("4.Выход");
                    a = Int32.Parse( Console.ReadLine());
                    switch (a)
                    {
                        
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Ввывод баланса");
                            Console.WriteLine( NewClient.ShowBalance().ToString());
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Введите сумму для пополнения");
                            decimal add =Decimal.Parse( Console.ReadLine());
                            NewClient.AddBalance(add);
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Ввудите сумму для снятия");
                            decimal del = Decimal.Parse(Console.ReadLine());
                            NewClient.DeleteBalance(del);
                            break;
                        case 4:
                            x = false;
                            break;                            
                        default:                            
                            break;
                    }
                    
                    
                }
            }


        }
    }
}
