using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер шахматной доски: ");
            int boardSize = int.Parse(Console.ReadLine());

            //for (int rowBlock = 0; rowBlock < boardSize; rowBlock++)
            //{
            //    for (int line = 0; line < size; line++)
            //    {
            //        for (int colBlock = 0; colBlock < boardSize; colBlock++)
            //        {
            //            bool isBlack = (rowBlock + colBlock) % 2 == 0;
            //            for (int ch = 0; ch < size; ch++)
            //            {
            //                Console.Write(isBlack ? "*" : " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}

            for (int i = 0; i < boardSize; i++) 
            {
              for (int j = 0; j < boardSize; j++) 
                {

                    if ((i + j) % 2 == 0)//если четное серное если нет пробел
                        Console.Write("■ ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();
            }

        }
    }
}
