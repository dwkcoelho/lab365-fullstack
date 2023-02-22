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
        private int _bankNumbers;
        private int _agency;
        private string _name;
        private float _balance = 0;
        private AccountTypeEnum _accountType;

        public BankAccount(int bankNumbers, int agency, string name, AccountTypeEnum accountType)
        {
            _bankNumbers = bankNumbers;
            _agency = agency;
            _name = name;
            _accountType= accountType;
        }
        public BankAccount(string name, AccountTypeEnum accountType)
        {
            _name = name;
            _accountType = accountType;

            Random random = new Random();
            _bankNumbers = random.Next(0000, 9999);
            _agency = random.Next(0000, 9999);
        }
        public void Transfer(BankAccount account, float value) 
        { 
            if(value <= 0)
            {
                Console.WriteLine("The value must be greater than 0");
                return;
            }
            if(value > _balance)
            {
                Console.WriteLine("Insufficient funds");
                return;
            }

            _balance -= value;
            account.InsertBalance(value);
            Console.WriteLine($"Amount of R#$ {value} successfully transferred!");
        }
        public void InsertBalance(float value)
        {
            if (value > 0)
            {
                Console.WriteLine($"You added {value}USD balance.");
                _balance += value;
            } else
            {
                Console.WriteLine($"{value} It's invalid value.");
            }
        }
        public void WithdrawBalance(float value)
        {
            if (value > 0 & !(value > _balance))
            {
                Console.WriteLine($"You withdrew {value}USD from your account.");
               _balance -= value;
            }
            else
            {
                Console.WriteLine($"{value} It's invalid value.");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is {_balance}USD");
        }
    }
}
