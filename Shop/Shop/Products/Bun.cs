using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Bun : Product
    {
        public string Filling { get; set; } //начинка

        public Bun(string name, string manufacturer, string catalog, double price, string filling)
        {
            Catalog = catalog;
            Name = name;
            Filling = filling;
            Manufacturer = manufacturer;
            Price = price;
        }
        public override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Начинка: " + Filling);
            Console.SetCursorPosition(0, 27);
            Console.WriteLine(new string('-', 120));

        }
    }
}
