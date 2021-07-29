using System;
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
            Account acc = new Account(001, "Francisco", 1000.00);
            BusinessAccount bacc = new BusinessAccount(002, "RuffusLuthieria", 0.00, 500.00);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(003, "Carlinhos", 1000.00, 10000.00);
            Account acc3 = new SavingAccounts(004, "Maria", 200.00, 1000.00);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                //Forma convencional de fazer um casting
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.00);
                Console.WriteLine("Loan");
            }
            if (acc3 is SavingAccounts)
            {
                //Forma alternativa de fazer um casting
                SavingAccounts acc5 = acc3 as SavingAccounts;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
