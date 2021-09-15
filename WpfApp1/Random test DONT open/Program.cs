using System;
using System.Collections.Generic;

namespace Random_test_DONT_open
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toys = new List<Toy>();

            //instance 1 for toy
            Toy t1 = new Toy();

            t1.Manufacturer = "Beulah's Candyland";
            t1.Name = "Milk Chocolate Peanut Clusters 2 pounds";
            t1.Price = 57.00;
            t1.GetAisle();

            toys.Add(t1);

            foreach (var item in toys)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
