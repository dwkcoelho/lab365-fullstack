using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal.Class
{
    public class Dog : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Auau");
        }
    }
}
