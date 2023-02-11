using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankAccount.Class.Enum;

namespace bankAccount.Class
{
    public class BankAccount
    {
        public int bankNumbers;
        public int agency;
        public string name;
        public decimal balance = 0;

        public AccountTypeEnum accountType;
        public void InsertBalance(decimal value)
        {
            if (value > 0)
            {
                Console.WriteLine($"You added {value}USD balance.");
                balance += value;
            } else
            {
                Console.WriteLine($"{value} It's invalid value.");
            }
        }
        public void WithdrawBalance(decimal value)
        {
            if (value > 0 & !(value > balance))
            {
                Console.WriteLine($"You withdrew {value}USD from your account.");
                balance -= value;
            }
            else
            {
                Console.WriteLine($"{value} It's invalid value.");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is {balance}USD");
        }
    }
}
