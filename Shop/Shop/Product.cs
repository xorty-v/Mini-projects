using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Catalog { get; set; }
        public double Price { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            return Price;
        }
        public virtual void ShowProduct()
        {
            Console.WriteLine(
                Catalog + ":" + "\n" +
                "Название товара: " + Name + "\n" +
                "Производитель: " + Manufacturer + "\n" +
                "Цена:" + Price + "$");
        }

    }
}