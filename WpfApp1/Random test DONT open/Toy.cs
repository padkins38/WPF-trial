using System;
using System.Collections.Generic;
using System.Text;

namespace Random_test_DONT_open
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        private string Aisle;
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Image = "";
            Aisle = "";
        }
        public Toy(string manufacturer, string name, double price, string image)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Image = image;
        }
        public override string ToString()
        {
            Console.WriteLine();
            return $"Manufacturer : {Manufacturer} \nProduct Name : {Name} \nPrice : {Price.ToString("c2")} \nOn Aisle {GetAisle()}";
        } 
        
        /// <summary>
        /// Returns the first letter of the Manufacturer, capitalized with the value of the Price afterwards (with no punctuation like . or , or $).
        /// </summary>
        /// <returns></returns>
        public string GetAisle()
        {
            string price = Price.ToString();
            if (price.Contains("$"))
            {
                price.Remove('$');
            }
            else if (price.Contains("."))
            {
                price.Remove('.');
            }
            string aisle = Manufacturer[0].ToString().ToUpper() + price;
            return aisle;
        }
    }
}
