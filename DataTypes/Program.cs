using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void printByte()
        {
            Console.WriteLine($"Name: {typeof(byte).Name}");
            Console.WriteLine($"Size: {sizeof(byte)}");
            Console.WriteLine($"Byte: {byte.MinValue} . . .{byte.MaxValue}");
            Console.WriteLine();
        }

        static void printSByte()
        {
            Console.WriteLine($"Name: {typeof(sbyte).Name}");
            Console.WriteLine($"Size: {sizeof(sbyte)}");
            Console.WriteLine($"sByte: {sbyte.MinValue} . . .{sbyte.MaxValue}");
            Console.WriteLine();
        }
        static void printShort()
        {
            Console.WriteLine($"Name: {typeof(short).Name}");
            Console.WriteLine($"Size: {sizeof(short)}");
            Console.WriteLine($"short: {short.MinValue} . . .{short.MaxValue}");
            Console.WriteLine();
        }

        static void printUshort()
        {
            Console.WriteLine($"Name: {typeof(ushort).Name}");
            Console.WriteLine($"Size: {sizeof(ushort)}");
            Console.WriteLine($"ushort: {ushort.MinValue} . . .{ushort.MaxValue}");
            Console.WriteLine();
        }

        static void printInt()
        {
            Console.WriteLine($"Name: {typeof(int).Name}");
            Console.WriteLine($"Size: {sizeof(int)}");
            Console.WriteLine($"int: {int.MinValue} . . .{int.MaxValue}");
            Console.WriteLine();
        }

        static void printUint()
        {
            Console.WriteLine($"Name: {typeof(uint).Name}");
            Console.WriteLine($"Size: {sizeof(uint)}");
            Console.WriteLine($"uint: {uint.MinValue} . . .{uint.MaxValue}");
            Console.WriteLine();
        }

        static void printLong()
        {
            Console.WriteLine($"Name: {typeof(long).Name}");
            Console.WriteLine($"Size: {sizeof(long)}");
            Console.WriteLine($"uint: {long.MinValue} . . .{long.MaxValue}");
            Console.WriteLine();
        }

        static void printULong()
        {
            Console.WriteLine($"Name: {typeof(ulong).Name}");
            Console.WriteLine($"Size: {sizeof(ulong)}");
            Console.WriteLine($"ulong: {ulong.MinValue} . . .{ulong.MaxValue}");
            Console.WriteLine();
        }

        static void printFloat()
        {
            Console.WriteLine($"Name: {typeof(float).Name}");
            Console.WriteLine($"Size: {sizeof(float)}");
            Console.WriteLine($"float: {float.MinValue} . . .{float.MaxValue}");
            Console.WriteLine();
        }

        static void printDouble()
        {
            Console.WriteLine($"Name: {typeof(double).Name}");
            Console.WriteLine($"Size: {sizeof(double)}");
            Console.WriteLine($"double: {double.MinValue} . . .{double.MaxValue}");
            Console.WriteLine();
        }

        static void printDecimal()
        {
            Console.WriteLine($"Name: {typeof(decimal).Name}");
            Console.WriteLine($"Size: {sizeof(decimal)}");
            Console.WriteLine($"decimal: {decimal.MinValue} . . .{decimal.MaxValue}");
            Console.WriteLine();
        }

        static void printBool()
        {
            Console.WriteLine($"Name: {typeof(bool).Name}");
            Console.WriteLine($"Size: {sizeof(bool)}");
            Console.WriteLine($"bool: {1} {0}");
            Console.WriteLine();
        }

        static void printChar()
        {
            Console.WriteLine($"Name: {typeof(char).Name}");
            Console.WriteLine($"Size: {sizeof(char)}");
            Console.WriteLine($"char: {(int)char.MinValue} . . .{(int)char.MaxValue}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int choise;
            do
            {
              
                Console.WriteLine("DataTypes");
                Console.Write("Выберите пункт меню: " + '\n' +
                    "0. Характеристика всех типов: " + '\n' +
                    "1. Характеристика типа byte" + '\n' +
                    "2. Характеристика типа sbyte" + '\n' +
                    "3. Характеристика типа short" + '\n' +
                    "4. Характеристика типа ushort" + '\n' +
                    "5. Характеристика типа int" + '\n' +
                    "6. Характеристика типа uint" + '\n' +
                    "7. Характеристика типа long" + '\n' +
                    "8. Характеристика типа ulong" + '\n' +
                    "9. Характеристика типа float" + '\n' +
                    "10. Характеристика типа double" + '\n' +
                    "11. Характеристика типа decimal" + '\n' +
                    "12. Характеристика типа bool" + '\n' +
                    "13. Характеристика типа char" + '\n' +
                    "14. Выход");
                Console.WriteLine();
                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 0:
                        printByte();
                        printSByte();
                        printShort();
                        printUshort();
                        printInt();
                        printUint();
                        printLong();
                        printULong();
                        printFloat();
                        printDouble();
                        printDecimal();
                        printBool();
                        printChar();
                        break;

                    case 1: printByte(); break;
                    case 2: printSByte(); break;
                    case 3: printShort(); break;
                    case 4: printUshort(); break;
                    case 5: printInt(); break;
                    case 6: printUint(); break;
                    case 7: printLong(); break;
                    case 8: printULong(); break;
                    case 9: printFloat(); break;
                    case 10: printDouble(); break;
                    case 11: printDecimal(); break;
                    case 12: printBool(); break;
                    case 13: printChar(); break;
                    case 14: Console.WriteLine(" Пока-пока. "); break;
                    default: Console.WriteLine("Ошибка. Нет пункта в меню."); break;
                }

            } while (choise != 14);
            
           

        }
    }
}
