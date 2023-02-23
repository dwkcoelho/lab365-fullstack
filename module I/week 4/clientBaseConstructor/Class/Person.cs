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

        public Person (string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }
    }
}
