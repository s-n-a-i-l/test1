using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.Title = "IMJS JSJ ksk";
            Console.Title = "ыв ываыв в";
            //Console.WindowWidth = 50;
            //Console.WindowHeight = 20;
            //Console.CursorTop = 8;
            //Console.CursorLeft = 16;
            Console.SetWindowSize(50, 20);
            Console.SetCursorPosition(16, 8);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Position");
            Console.Clear();
            //Console.ResetColor();
           // Console.;
        }
    }
}
