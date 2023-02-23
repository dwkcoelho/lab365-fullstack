using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Class
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public Address Address { get; set; }

        public Person (string name, DateTime birth, Address adress)
        {
            Name = name;
            Birth = birth;
            Address = adress;
        }
        public virtual void HaveBirthday ()
        {
            Birth = Birth.AddYears (1);
        }
    }
}
