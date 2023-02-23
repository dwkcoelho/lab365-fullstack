using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Class
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Office { get; set; }

        public Employee(string name, DateTime birth, Address adress,
            decimal salary, string office) : base (name, birth, adress)
        {
            Salary = salary;
            Office = office;
            Address = adress;
        }
        public void ReceiveRaise(decimal salary)
        {
            Salary += salary;
        }
        public override void HaveBirthday()
        {
            Salary *= 1.10M;
            base.HaveBirthday();
        }
        
    }
   
}
