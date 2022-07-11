using System;

namespace Painter
{
    class Menu
    {
        private Paint paint;

        public void Play()
        {
            Console.SetWindowSize(41, 20);
            Console.SetBufferSize(41, 20);
            Console.CursorVisible = false;

            Console.WriteLine("Выберите алгоритм:");
            Console.WriteLine("1) С помощью циклов\n2) Обход в ширину\n3) Обход в глубину");
            int userInput = int.Parse(Console.ReadLine());

            Console.Clear();
            paint = new Paint(40, 20);
            paint.PutRandomNumbers(400);

            switch (userInput)
            {
                case 1:
                    paint.FillFor(20, 10);
                    break;
                case 2:
                    paint.FillQueue(20, 10);
                    break;
                case 3:
                    paint.FillStack(20, 10);
                    break;
                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }

            Console.ReadKey();
        }
    }
}
