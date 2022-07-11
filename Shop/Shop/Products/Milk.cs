using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Milk : Product
    {
        public byte FatPercentage { get; set; } //процентное содержание жира

        public Milk(string name, string manufacturer, string catalog, double price, byte fatpercentage)
        {

            Catalog = catalog;
            Name = name;
            FatPercentage = fatpercentage;
            Manufacturer = manufacturer;
            Price = price;
        }
        public override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Жирность: " + FatPercentage+"%");
            Console.WriteLine(new string('-', 25));
        }
    }
}
