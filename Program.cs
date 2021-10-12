using System;

namespace SIGMA_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter the data in format(name, price, weight, dateofexpirationindays, date): [Coca-cola] [28,3] [0,5] [90] [14.06.2021]: ");
            string info = Console.ReadLine();

          
            Product a = new Product();
            a.Parse(info);
            Console.WriteLine(a.ToString());

            Storage storage = new Storage();

            storage.EnterInfo();
            storage.PrintInfo();
            storage.RemoveExpired();
            storage.ReadFromFile();
            storage.PrintInfo();

        }
    }
}

