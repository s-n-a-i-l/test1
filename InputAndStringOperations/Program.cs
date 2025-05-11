using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndStringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();
            
            Console.Write("Введите вашу фамилию: ");
            string second_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write(first_name);
            Console.Write(second_name);
            Console.Write(age);
            Console.WriteLine();

            Console.WriteLine(first_name + ' ' + second_name + ' ' + age);//конкантенация строк
            Console.WriteLine(string.Format("{0} {1} {2}", second_name, first_name, age));//форматирование строк
            Console.WriteLine($"{first_name} {second_name} {age}");//интерполяция строк

        }
    }
}
