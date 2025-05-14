using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomertry2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите размер ромба: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{ 
            //  for (int j = i; j< n; j++)  Console.Write(" ");  Console.Write("/");
                
            //  for(int j = 0; j < i*2; j++)  Console.Write(" "); Console.Write("\\"); 

            //    //Console.WriteLine();

            //    for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");

            //    for (int j = 0; j < (n - i - 1) * 2; j++) Console.Write(" "); Console.Write("/");

            //    Console.WriteLine();
            //}

            //for (int i = 0;i < n; i++) 
            //{

            //}

            Console.Write("Введите размер ромба: ");
            int n = int.Parse(Console.ReadLine());//парсим в инт, чтоб нельзя было вводить буковы,,,,очень удобно сразу с проверкой

            for (int i = 0; i < 2 * n - 1; i++)
            {

                if (i < n) // верх ромба
                {
                    
                    for (int j = 0; j < n - i - 1; j++) Console.Write(" "); Console.Write("/");
                    
                    for (int j = 0; j < i * 2; j++) Console.Write(" "); Console.Write("\\");
                }
                else // низ ромба
                {
                    int line = i - n;
       
                    for (int j = 0; j < line; j++) Console.Write(" "); Console.Write("\\");
                    
                    for (int j = 0; j < 2 * (n - line - 1); j++) Console.Write(" "); Console.Write("/");
                }

                Console.WriteLine();
            }

        }
    }
}
