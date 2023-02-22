using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merchandise.Class
{
    public class Merchandise
    {
        private string _name;
        private float _priece;
        private int _amount;
        private string _store;
        private DateTime? _expiration;
        public Merchandise(string name, float priece, int amount)
        {
            _name = name;
            _priece = priece;
            _amount = amount;

            _store = "Main Store";
            _expiration = DateTime.Parse("2022-12-31");
        }
        public Merchandise()
        {

        }
        public string Name
        {
            get { return _name; }
            set {
                if (!string.IsNullOrEmpty(value))
                    {
                    _name = value;
                    }
                }
        }
        public float Priece
        {
            get { return _priece; }
            set { 
                if(value > 0) 
                    {
                    _priece = value;
                    }
                }
        }
        public int Amount
        {
            get { return _amount; }
            set {
                if (value > 0)
                {
                    _amount = value;
                }
            }
        }
        public void DescribeMerchandise()
        {
           Console.WriteLine($"The product name is {_name}. \n" +
                $"The product price is {_priece}. \n" +
                $"and has the amount of {_amount}.");
        }
    }
}
