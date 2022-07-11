using System;
using Shop.Products;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FirstUser = new User("Ramazi", 150, 0);
            
            Store shop = new Store();

            Console.SetCursorPosition(45, 0);
            Console.WriteLine("Описание доступных продуктов:");
            Console.WriteLine(new string('-', 120));
            new Store().ShowCatalog();

            while (true)
            {
                Console.WriteLine("1.Оформить товар\n2.Просмотреть корзину\n3.Выход");
                Console.Write("Напишите номер действия и нажмите Enter: ");
                int numberAction = int.Parse(Console.ReadLine());

                switch (numberAction)
                {
                    case 1:
                        shop.BuyProduct(FirstUser);
                        break;
                    case 2:
                        shop.ShowBacket();
                        break;
                    case 3:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nНе верная команд.\n");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
