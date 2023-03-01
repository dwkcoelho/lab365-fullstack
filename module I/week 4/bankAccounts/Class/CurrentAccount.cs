using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankAccounts.Class.Enum;

namespace bankAccounts.Class
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(int number, int agency, Client client) : base(number, agency, client)
        {
            if (client.TypePerson != TypePerson.PHYSICAL)
            {
                throw new ArgumentException("Customer needs to be the physical type!");
            }
        }
        public override void WithdrawBalance(decimal value)
        {
            value += 0.50M;
            base.WithdrawBalance(value);
        }
        public override void Transfer(BankAccount account, decimal value)
        {
            value += 0.25M;
            base.Transfer(account, value);
        }
    }
}
