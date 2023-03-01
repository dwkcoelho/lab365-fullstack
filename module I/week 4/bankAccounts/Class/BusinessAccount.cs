using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankAccounts.Class.Enum;

namespace bankAccounts.Class
{
    public class BusinessAccount : BankAccount
    {
        public decimal LoanLimit { get; private set; }
        public decimal InterestRate { get; private set; }
        public bool HaveLoan { get; private set; }
        public decimal ValueUsed { get; private set; }
        public string CNPJ { get; private set; }

        public BusinessAccount(int number, int agency, Client client, decimal loanLimit, decimal interestRate,
           string cnpj) 
            : base(number, agency, client)
        {
            LoanLimit = loanLimit;
            InterestRate = interestRate;
            CNPJ = cnpj;

            if(client.TypePerson != TypePerson.LEGAL)
            {
                throw new ArgumentException("Customer needs to be the legal type!");
            }
        }
        public void MakeLoan (decimal value)
        {
            if (value <= 0)
            {
                Console.WriteLine("The value must be greater than 0!");
                return;
            }
            if (HaveLoan)
            {
                Console.WriteLine("You already have an active loan!");
                return;
            }
            if (value > LoanLimit)
            {
                Console.WriteLine("The amount exceeds your available loan limit!");
                return;
            }
            HaveLoan = true;
            base.InsertBalance (value);
            ValueUsed = value;
            Console.WriteLine($"Loan in the amount of USD {value} successfully completed!");
        }
        public void PayLoan()
        {
            decimal total = ValueUsed + (ValueUsed * InterestRate / 100);
            if (total > Balance)
            {
                Console.WriteLine("You don't have enough balance to make the payment!");
                return;
            }
            WithdrawBalance(total);
            HaveLoan = false;
            ValueUsed = 0;
            Console.WriteLine($"Loan in the total amount of USD {total} successfully paid!");
        }
        public override void WithdrawBalance(decimal value)
        {
            value += 1;
            base.WithdrawBalance(value);
        }
        public override void Transfer(BankAccount account, decimal value)
        {
            value += 0.50M;
            base.Transfer(account, value);
        }
    }
}
