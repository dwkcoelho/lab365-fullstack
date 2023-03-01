using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccounts.Class
{
    public class BankAccount
    {
        public int Number { get; protected set; }
        public int Agency { get; protected set; }
        public decimal Balance { get; protected set; }
        public Client Client { get; protected set; }

        public BankAccount(int number, int agency, Client client)
        {
            Number = number;
            Agency = agency;
            Client = client;
            Balance = 0;
        }
        public virtual void Transfer(BankAccount account, decimal value)
        {
            if (value <= 0)
            {
                Console.WriteLine("The value must be greater than 0");
                return;
            }
            if (value > Balance)
            {
                Console.WriteLine("Insufficient funds");
                return;
            }

            Balance -= value;
            account.InsertBalance(value);
            Console.WriteLine($"Amount of R#$ {value} successfully transferred!");
        }
        public virtual void InsertBalance(decimal value)
        {
            if (value > 0)
            {
                Console.WriteLine($"You added {value}USD balance.");
                Balance += value;
            }
            else
            {
                Console.WriteLine($"{value} It's invalid value.");
            }
        }
        public virtual void WithdrawBalance(decimal value)
        {
            if (value > 0 & !(value > Balance))
            {
                Console.WriteLine($"You withdrew {value}USD from your account.");
                Balance -= value;
            }
            else
            {
                Console.WriteLine($"{value} It's invalid value.");
            }
        }
        public virtual void ShowBalance()
        {
            Console.WriteLine($"Your balance is {Balance}USD");
        }
    }
}
