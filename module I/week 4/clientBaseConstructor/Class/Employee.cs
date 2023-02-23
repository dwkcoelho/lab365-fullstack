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

        public Employee(string name, DateTime birth,
            decimal salary) : base (name, birth)
        {
            Salary = salary;
        }
        public void ReceiveRaise(decimal salary)
        {
            Salary += salary;
        }
    }
   
}
