using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosCursoCSharp.Entities.Exception;

namespace ExerciciosCursoCSharp.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance <= 0)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
