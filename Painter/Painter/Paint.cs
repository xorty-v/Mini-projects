using System;
using System.Collections.Generic;
using System.Threading;

namespace Painter
{

    class Paint
    {
        private int[,] map;
        private int w, h;
        private string symbols = " #+x";

        public ConsoleColor[] colors =
        {
            ConsoleColor.White,
            ConsoleColor.DarkBlue,
            ConsoleColor.Yellow,
            ConsoleColor.Red
        };

        public Paint(int w, int h)
        {
            this.w = w;
            this.h = h;
            map = new int[w, h];
        }

        private void SetMap(int x, int y, int number)
        {
            if (x < 0 || x >= w) return;
            if (y < 0 || y >= w) return;
            map[x, y] = number;

            PrintAt(x, y);
        }

        private void PrintAt(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[map[x, y]];
            Console.Write(symbols[map[x, y]]);
        }

        public void PutRandomNumbers(int count)
        {
            var random = new Random();

            for (int i = 0; i < count; i++)
                SetMap(random.Next(w), random.Next(h), 1);
        }

        public void FillFor(int px, int py)
        {
            SetMap(px, py, 2);

            while (true)
            {
                bool stop = true;

                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {
                        if (map[x, y] == 2)
                        {
                            Thread.Sleep(100);
                            stop = false;

                            SetMap(x, y, 3);
                            if (IsEmpty(x - 1, y)) SetMap(x - 1, y, 2);
                            if (IsEmpty(x + 1, y)) SetMap(x + 1, y, 2);
                            if (IsEmpty(x, y - 1)) SetMap(x, y - 1, 2);
                            if (IsEmpty(x, y + 1)) SetMap(x, y + 1, 2);
                        }
                    }
                }

                if (stop) break;
            }
        }

        public void FillQueue(int px, int py)
        {

            SetMap(px, py, 2);

            Queue<Coord> queue = new Queue<Coord>();
            queue.Enqueue(new Coord(px, py));

            while (queue.Count > 0)
            {
                Thread.Sleep(100);
                Coord coord = queue.Dequeue();
                int x = coord.x;
                int y = coord.y;
                SetMap(x, y, 3);

                if (IsEmpty(x - 1, y)) { queue.Enqueue(new Coord(x - 1, y)); SetMap(x - 1, y, 2); }
                if (IsEmpty(x + 1, y)) { queue.Enqueue(new Coord(x + 1, y)); SetMap(x + 1, y, 2); }
                if (IsEmpty(x, y - 1)) { queue.Enqueue(new Coord(x, y - 1)); SetMap(x, y - 1, 2); }
                if (IsEmpty(x, y + 1)) { queue.Enqueue(new Coord(x, y + 1)); SetMap(x, y + 1, 2); }
            }
        }

        public void FillStack(int px, int py)


        {
            SetMap(px, py, 2);

            Stack<Coord> stack = new Stack<Coord>();
            stack.Push(new Coord(px, py));

            while (stack.Count > 0)
            {
                Thread.Sleep(100);
                Coord coord = stack.Pop();
                int x = coord.x;
                int y = coord.y;
                SetMap(x, y, 3);

                if (IsEmpty(x - 1, y)) { stack.Push(new Coord(x - 1, y)); SetMap(x - 1, y, 2); }
                if (IsEmpty(x + 1, y)) { stack.Push(new Coord(x + 1, y)); SetMap(x + 1, y, 2); }
                if (IsEmpty(x, y - 1)) { stack.Push(new Coord(x, y - 1)); SetMap(x, y - 1, 2); }
                if (IsEmpty(x, y + 1)) { stack.Push(new Coord(x, y + 1)); SetMap(x, y + 1, 2); }
            }
        }

        private bool IsEmpty(int x, int y)
        {
            if (x < 0 || x >= w) return false;
            if (y < 0 || y >= h) return false;

            return map[x, y] == 0;
        }
    }
}