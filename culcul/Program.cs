using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace culcul
{
    internal class Program
    {

        static char[] op = new char[] { '+', '-', '/', '*' };//массив возможных операций
        static char[] digits = "0123456789. ".ToCharArray();//--\\-- но числа
        static void Main(string[] args)
        {

            //Console.Write("Введите арифметическое выражение: ");
            string expression = "22+33-44/2+6*8";
            //Console.Write(expression);
            string[] s_values = expression.Split(op);
            double[] values = new double[s_values.Length];
            for (int i = 0; i < s_values.Length; i++)
            {
                Console.Write($"{s_values[i] + '\t'}");
                values[i] = Convert.ToDouble(s_values[i]);
            }
            Console.WriteLine();

            string[] ops = expression.Split(digits);
            ops = ops.Where(o => o != "").ToArray();

            for (int i = 0; i < ops.Length; i++)
            {
                Console.Write($"{ops[i] + "\t"}");
            }
            Console.WriteLine();


            #region Simple
            /* double a = Convert.ToDouble(values[0]);
                double b = Convert.ToDouble(values[1]);// возможно массив со значениями и вытаскивать по индексу

                Console.Write(expression);
                char current_op = expression[expression.IndexOfAny(op)];
                switch (current_op) 
                {
                 case '+': Console.WriteLine($" = {a + b}");break;
                 case '-': Console.WriteLine($" = {a - b}"); break;
                 case '/': Console.WriteLine($" = {a / b}"); break;
                 case '*': Console.WriteLine($" = {a * b}"); break;
                 default: Console.WriteLine("error: no operation");break;
                }*/
            #endregion

            while (ops.Contains("*") || ops.Contains("/"))
            {
                for (int i = 0; i < ops.Length; i++)
                {
                    if (ops[i] == "*") values[i] *= values[i + 1];
                    if (ops[i] == "/") values[i] /= values[i + 1];

                    if (ops[i] == "*" || ops[i] == "/")
                    {
                        for (int j = i + 1; j < ops.Length; j++)
                        {
                            ops[j - 1] = ops[j];
                            values[j] = values[j + 1];
                        }
                        if (ops[ops.Length - 1] != " ")
                        {
                            ops[ops.Length - 1] = " ";
                            values[values.Length - 1] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < values.Length; i++) Console.Write(values[i] + "\t"); Console.WriteLine();
            for (int i = 0; i < ops.Length; i++) Console.Write(ops[i] + "\t"); Console.WriteLine(); 
            
            Console.WriteLine();
            while (ops.Contains("+") || ops.Contains("-"))
            {
                
                    if (ops[0] == "+") values[0] += values[1];
                    if (ops[0] == "-") values[0] -= values[1];
                    if (ops[0] == "+" || ops[0] == "-")
                    {
                        for (int j = 1; j < ops.Length; j++)
                        {
                            ops[j - 1] = ops[j];
                            values[j] = values[j + 1];
                        }
                        if (ops[ops.Length - 1] != " ")
                        {
                            ops[ops.Length - 1] = " ";
                            values[values.Length - 1] = 0;
                        }
                    }
                
            }
            for (int i = 0; i < values.Length; i++) Console.Write(values[i] + "\t"); Console.WriteLine();
            for (int i = 0; i < ops.Length; i++) Console.Write(ops[i] + "\t"); Console.WriteLine();
        }
    }
}
