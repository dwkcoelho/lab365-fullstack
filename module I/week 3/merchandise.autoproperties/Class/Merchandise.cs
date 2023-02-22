using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merchandise.Class
{
    public class Merchandise
    {
        public string Name { get; set; }
        private float Priece { get; set; }
        private int Amount { get; set; }
        private string _store;
        private DateTime? _expiration;
        public Merchandise(string name, float priece, int amount)
        {
            Name = name;
            Priece = priece;
            Amount = amount;

            _store = "Main Store";
            _expiration = DateTime.Parse("2022-12-31");
        }
        public Merchandise()
        {

        }
        public void DescribeMerchandise()
        {
           Console.WriteLine($"The product name is {Name}. \n" +
                $"The product price is {Priece}. \n" +
                $"and has the amount of {Amount}.");
        }
    }
}
