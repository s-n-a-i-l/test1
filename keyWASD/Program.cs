using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace keyWASD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int x = 10; // начальная позиция по X
                int y = 10; // начальная позиция по Y
                ConsoleKeyInfo key;

                Console.CursorVisible = false;

                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write("<3"); // символ курсора

                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.W:
                        case ConsoleKey.UpArrow:
                            if (y > 0) y--;
                            break;
                        case ConsoleKey.S:
                        case ConsoleKey.DownArrow:
                            if (y < Console.WindowHeight - 1) y++;
                            break;
                        case ConsoleKey.A:
                        case ConsoleKey.LeftArrow:
                            if (x > 0) x--;
                            break;
                        case ConsoleKey.D:
                        case ConsoleKey.RightArrow:
                            if (x < Console.WindowWidth - 1) x++;
                            break;
                        case ConsoleKey.Escape:
                            return; // выход из программы
                    }

                    Thread.Sleep(50); // задержка, чтобы не было слишком быстро
                }
            }
        }
    }
}