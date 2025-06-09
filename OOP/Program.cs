using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(10, 20);
            Fraction frac2 = new Fraction(12, 15);
  
            Fraction plus = frac1 + frac2; // Сокращенная дробь 13/10
            Fraction minus = frac1 - frac2;// Сокращенная дробь -3/10
            Fraction umno = frac1 * frac2;// Сокращенная дробь 2/5
            Fraction del = frac1 / frac2;// Сокращенная дробь 5/8

            Fraction frac3 = new Fraction(10, 0);
            Fraction frac4 = new Fraction();

            Fraction p = frac3 + frac4; 
            Fraction m = frac3 - frac4;
            Fraction u = frac3 * frac4;
            Fraction d = frac3 / frac4;
            Console.ReadLine();
        }
    }
}
