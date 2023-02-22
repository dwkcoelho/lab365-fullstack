using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Class
{
    public class Client
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public Address Address { get; set; }

        public Client(string name, DateTime birth, Address address)
        {
            Name = name;
            Birth = birth;
            Address = address;
        }
    }
}
