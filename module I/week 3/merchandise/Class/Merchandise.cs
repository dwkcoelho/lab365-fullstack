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
        public string GetName() 
        { 
            return _name; 
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                _name = name;
            }
        }
        public float GetPriece()
        {
            return _priece;
        }
        public void SetPriece(float priece)
        {
            if (priece > 0)
            {
                _priece = priece;
            }
        }
        public float GetAmount()
        {
            return _amount;
        }
        public void SetAmount(int amount)
        {
            if (amount > 0)
            {
                _amount = amount;
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
