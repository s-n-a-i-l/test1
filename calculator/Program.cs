using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение(+-*/):");
          
            double number = Convert.ToDouble(Console.ReadLine());
            char op = Convert.ToChar(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = number + number2;
                    Console.WriteLine("Результат: " + result);
                    break;
                case '-':
                    result = number - number2;
                    Console.WriteLine("Результат: " + result);
                    break;
                case '*': 
                    result = number * number2;
                    Console.WriteLine("Результат: " + result);
                    break;
                case '/':
                    if (number == 0 || number2 == 0)
                    {
                      Console.WriteLine("Ошибка операция / на нуль или нуль на число невозможна.");
                    }
                    else
                    {
                    result = number / number2;
                    Console.WriteLine("Результат: " + result);
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    break;

            }

            // double number = Convert.ToDouble(Console.ReadLine());
          
        }
    }
}
