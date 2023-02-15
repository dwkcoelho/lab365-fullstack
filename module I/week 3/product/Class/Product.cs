using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Class
{
    public class Product
    {
        public string name;
        public double price;
        public int amount;

        public Product(string name, double price, int amount)
        { 
            this.name = name;
            this.price = price;
            this.amount = amount;   
        }
        public Product()
        {
            this.name = "Unnamed";
            this.price = 0;
            this.amount = 0;
        }

    }
}
