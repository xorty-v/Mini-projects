using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Water : Product
    {
        public string Carbonated { get; set; } //газированная 

        public Water(string name, string manufacturer, string catalog, double price, string carbonated)
        {
            Catalog = catalog;
            Name = name;
            Carbonated = carbonated;
            Manufacturer = manufacturer;
            Price = price;
        }
        public override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Газированная: " + Carbonated);
            Console.WriteLine(new string('-', 25));
        }
    }
}
