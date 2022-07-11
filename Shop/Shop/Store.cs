using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shop.Products;

namespace Shop
{
    internal class Store
    {
        public List<Product> products;
        public List<Product> basket;
        public Store()
        {
            products = new List<Product>
            {
                new Water("Borjomi", "IDS Borjomi International", "Вода", 7.9, "Нет"),
                new Milk("Сливки", "Lactalis", "Молочное", 15, 4),
                new Chips("Lays", "Lays Company", "Чипсы", 12, "Смета и лук"),
                new Bun("Булочка", "Homelike", "Кондитерское изделие", 2.5, "Шоколад"),
            };
            basket = new List<Product>();
        }
        public void ShowCatalog()
        {
            foreach (var product in products)
            {
                product.ShowProduct();
            }
        }

        public void ShowBacket()
        {
            if (basket.Count > 0)
            {
                foreach (var ProductInBacket in basket)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Список продуктов добавленных в корзину:");
                    Console.ResetColor();
                    for (int i = 0; i < basket.Count; i++)
                    {
                        Console.WriteLine($"Товар {i + 1} - {basket[i].Name} по цене - {basket[i].Price}$");
                    }

                    Console.WriteLine("Для выхода из корзины нажмите Enter\n");
                    Console.ReadKey();
                    break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nПока в корзине пусто :(\n");
                Console.ResetColor();
            }
        }

        public void BasketAdd(int productNumber)
        {

            basket.Add(products[productNumber]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nПродукт {products[productNumber].Name} - успешно добавлен в корзину!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"В корзине {basket.Count} продукт(ов).\n");
            Console.ResetColor();
        }


        public void BuyProduct(User FirstUser)
        {
            Console.Clear();
            bool exit = true;
            var informer = new Informer();

            while (exit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{FirstUser.Name} ваш баланс - {FirstUser.Balance}$\n");
                Console.ResetColor();

                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"Товар {i + 1} - {products[i].Name} по цене - {products[i].Price}$");
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Напишите номер товара и нажмите Enter: ");
                Console.ResetColor();
                int productNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                if (productNumber >= 0 && productNumber < products.Count)
                {
                    if (products[productNumber].Price <= FirstUser.Balance)
                    {
                        informer.Buy(FirstUser, products[productNumber]);
                        BasketAdd(productNumber);

                        Console.Write("Выйти в главное меню - y/n: ");
                        if (IsYes(Console.ReadLine()))
                        {
                            exit = false;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nУ вас недостаточно средств\nЖдем вас с деньгами :)\n");
                        Console.ResetColor();
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Упс... Попробуйте еще раз");
                    Console.ResetColor();
                }
            }
        }
        static bool IsYes(string yes)
        {
            if (yes.ToLower() == "y")
            {
                return true;
            }
            return false;

        }
    }
}
