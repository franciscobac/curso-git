using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ExerciciosCursoCSharp.Entities;
using ExerciciosCursoCSharp.Entities.Exception;

namespace ExerciciosCursoCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new Account();
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double balance = amount;
            acc.Deposit(amount);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}
