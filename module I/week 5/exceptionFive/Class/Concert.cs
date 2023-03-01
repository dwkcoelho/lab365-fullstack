using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions.Class
{
    internal class Concert
    {
        int quantityPlaces, quantitySell;

        public Concert ()
        {

        }
        public int QuantityPlaces { get; set; }
        public int QuantitySell { get; set;}
        public void ticketSold()
        {
            Console.WriteLine("Ticket sold successfully!");
        }
    }
}
