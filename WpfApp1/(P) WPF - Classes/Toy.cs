using System;
using System.Collections.Generic;
using System.Text;

namespace _P__WPF___Classes
{
    public class Toy
    {
        public string Manufacturer {get; set;}
        public string Name {get; set;}
        public double Price {get; set;}
        public string Image {get; set;}

        private string Aisle;
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Image = "";
            Aisle = "";
        }
        public string GetAisle()
        {
            string priceNoDot = Price.ToString().Replace('.',' ');
            string aisle = Manufacturer[0].ToString().ToUpper() + priceNoDot;
            return aisle;
        }
        /*public Toy(string manufacturer, string name, double price, string image)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Image = image;
        }*/

        public override string ToString()
        {                      
            return $"{Manufacturer} + {Name}";            
        }
    }
}
