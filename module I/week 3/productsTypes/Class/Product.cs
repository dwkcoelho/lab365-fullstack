using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productsTypes.Class
{
    internal class Product
    {
        public string name;
        protected string category;
        private double amount, priece;

        public Product(string name, string category)
        {
            this.name = name;
            this.category = category;
        }

        public Product()
        {
        }

        public void checkStock()
        {
            Console.WriteLine("Checking stock, accessing the product class method");
        }
        protected void sell()
        {
            Console.WriteLine("Selling product, accessing the sell method of the product class");
        }

        protected void changePrivateAtributtes(double amount, double priece)
        {
            this.amount = amount;
            this.priece = priece;
            Console.WriteLine($"Amount: " + amount + "\n" + "Priece: " + priece);
        }
        private void discard()
        {
            Console.WriteLine("Discarding the product");
        }
    }
}
