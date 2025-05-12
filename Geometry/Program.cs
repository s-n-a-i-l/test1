using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {

        static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void PrintRightDownTriangle(int size) 
        {
            for (int i = 0; i < size; i++)
            {
                for (int space = 0; space < size - i - 1; space++)
                    Console.Write("  ");
                for (int star = 0; star <= i; star++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        static void PrintRightUpTriangle(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                for (int space = 0; space < size - i; space++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        static void PrintLeftUpTriangle(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintLeftDownTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintChessBoard(int size) 
        {
            int boardSize = 8; // Стандартная шахматная доска

            for (int rowBlock = 0; rowBlock < boardSize; rowBlock++) // по строкам клеток
            {
                for (int line = 0; line < size; line++) // по строкам внутри клетки
                {
                    for (int colBlock = 0; colBlock < boardSize; colBlock++) // по столбцам клеток
                    {
                        bool isBlack = (rowBlock + colBlock) % 2 == 0;
                        for (int ch = 0; ch < size; ch++) // символы внутри клетки
                        {
                            Console.Write(isBlack ? "*" : " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static void PrintRhombus(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                // Пробелы перед левой стороной
                Console.Write(new string(' ', size - i));
                Console.Write("/");

                if (i == 1)
                {
                    Console.WriteLine("\\");
                }
                else
                {
                    Console.Write(new string(' ', 2 * i - 2));
                    Console.WriteLine("\\");
                }
            }

            // НИЗ
            for (int i = size; i >= 1; i--)
            {
                Console.Write(new string(' ', size - i));
                Console.Write("\\");

                if (i == 1)
                {
                    Console.WriteLine("/");
                }
                else
                {
                    Console.Write(new string(' ', 2 * i - 2));
                    Console.WriteLine("/");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер: ");
            int size = Convert.ToInt32(Console.ReadLine());

            PrintSquare(size);
            Console.WriteLine();

            PrintRightDownTriangle(size);
            Console.WriteLine();

            PrintRightUpTriangle(size);
            Console.WriteLine();

            PrintLeftUpTriangle(size);
            Console.WriteLine();

            PrintLeftDownTriangle(size);
            Console.WriteLine();

            PrintRhombus(size);
            Console.WriteLine();

            PrintChessBoard(size);
            Console.WriteLine();

        }
    }
}
