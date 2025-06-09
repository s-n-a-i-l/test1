using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public int numerator_ { get; set; }
        public int denominator;
        public int denominator_
        {
            get 
            { 
                return denominator; 
            }
            set
            {
                if (value != 0)
                    denominator = value;
                else
                    Console.Error.WriteLine("Ошибка! деление на ноль.\a");
            }
        }

        public Fraction(int numerator = 3, int denominator = 4)
        {
            numerator_ = numerator;
            denominator_ = denominator;
        }
        public static int gcd(int numerator, int denominator)
        {
            while (denominator != 0)
            {
                int temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }

            return numerator;
        }
        public static void reduction(int numerator, int denominator)
        {
            int reduct = gcd(numerator, denominator);
            numerator /= reduct;
            denominator /= reduct;
            Console.WriteLine($"{numerator}/{denominator}");
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int new_numerator_ = left.numerator_ * right.denominator_ + right.numerator_ * left.denominator_;
            int new_denominator_ = right.denominator_ * left.denominator_;
            Fraction result = new Fraction(new_numerator_, new_denominator_);
            reduction(result.numerator_, result.denominator_);
            return result;
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            int new_numerator_ = left.numerator_ * right.denominator_ - right.numerator_ * left.denominator_;
            int new_denominator_ = left.denominator_ * right.denominator_;
            Fraction result = new Fraction(new_numerator_, new_denominator_);
            reduction(result.numerator_, result.denominator_);
            return result;
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            int new_numerator_ = left.numerator_ * right.numerator_;
            int new_denominator_ = right.denominator_ * left.denominator_;
            Fraction result = new Fraction(new_numerator_, new_denominator_);
            reduction(result.numerator_, result.denominator_);
            return result;
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            int new_numerator_ = left.numerator_ * right.denominator_;
            int new_denominator_ = left.denominator_ * right.numerator_;
            Fraction result = new Fraction(new_numerator_, new_denominator_);
            reduction(result.numerator_, result.denominator_);
            return result;
        }
    }
}
