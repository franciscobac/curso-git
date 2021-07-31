﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosCursoCSharp.Entities;

namespace ExerciciosCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAccounts(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingAccounts(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.00);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}
