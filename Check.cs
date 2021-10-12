using System;
using System.Collections.Generic;
using System.Text;

namespace SIGMA_2
{
    sealed class Check
    {
        public void ShowResult(Product obj1, Buy obj2)
        {
            Console.WriteLine("Product\n" + "Name: " + obj1.Name);
            Console.WriteLine("Price: " + obj1.Price + " grn");
            Console.WriteLine("Weight: " + obj1.Weight + " kg");
            Console.WriteLine("\nGeneral price: " + obj2.Sum + " grn");
            Console.WriteLine("General weight: " + obj2.Weight + " kg");
        }
    };

}
