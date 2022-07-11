using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Chips : Product
    {
        public string Taste { get; set; }
        public Chips(string name, string manufacturer, string catalog, double price, string taste)
        {
            Catalog = catalog;
            Name = name;
            Taste = taste;
            Manufacturer = manufacturer;
            Price = price;
        }
        public override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Вкус: " + Taste);
            Console.WriteLine(new string('-', 25));
        }
    }
}
