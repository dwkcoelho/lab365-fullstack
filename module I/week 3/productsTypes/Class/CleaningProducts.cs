using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productsTypes.Class
{
    internal class CleaningProducts : Product
    {
        public void acess()
        {
            CleaningProducts thirdProduct = new CleaningProducts();
            thirdProduct.name = "Soap";
            thirdProduct.category = "Cleaning";
            Console.WriteLine($"Name: {thirdProduct.name} \nCategory: {thirdProduct.category}");
            thirdProduct.checkStock();
            thirdProduct.sell();
            thirdProduct.changePrivateAtributtes(200, 1.83);
        }
    }
}
