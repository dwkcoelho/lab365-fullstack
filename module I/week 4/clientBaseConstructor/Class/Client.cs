using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Class
{
    public class Client : Person
    {
        public string Store { get; set; }
        public Client(string name, DateTime birth, 
            string store) : base (name, birth)
        { 
            Store = store;
        }
    }
}
