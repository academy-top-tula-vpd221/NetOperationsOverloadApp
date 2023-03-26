using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOperationsOverloadApp
{
    internal class Fraction
    {
        public int Numerator { set; get; }
        int denominator;
        public int Denominator 
        {
            set
            {
                if (value != 0)
                    denominator = value;
                else
                    throw new ArgumentException("Denominator is zero");
            }
                
            get => denominator;
        }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"[{Numerator}/{Denominator}]";
        }

        public static implicit operator Fraction(int number)
        {
            return new Fraction()
            {
                Numerator = number,
                Denominator = 1
            };
        }

        public static implicit operator Fraction(double x)
        {
            int num = (int)x;
            num = (int)((x - num) * 100) + num*100;
            return new Fraction()
            {
                Numerator = num,
                Denominator = 100
            };
        }

        public static explicit operator Fraction(Money m)
        {
            return new Fraction()
            {
                Numerator = m.Rub * 100 + m.Cop,
                Denominator = 100
            };
        }

        public static Fraction operator+(Fraction a, Fraction b)
        {
            return new Fraction()
            {
                Numerator = a.Numerator * b.Denominator + a.Denominator * b.Numerator,
                Denominator = a.Denominator * b.Denominator
            };
        }
        public static Fraction operator +(Fraction a, int n)
        {
            return new Fraction()
            {
                Numerator = a.Numerator + a.Denominator * n,
                Denominator = a.Denominator
            };
        }
        public static Fraction operator-(Fraction a, Fraction b)
        {
            return new Fraction()
            {
                Numerator = a.Numerator * b.Denominator - a.Denominator * b.Numerator,
                Denominator = a.Denominator * b.Denominator
            };
        }
        public static Fraction operator*(Fraction a, Fraction b)
        {
            return new Fraction()
            {
                Numerator = a.Numerator * b.Numerator,
                Denominator = a.Denominator * b.Denominator
            };
        }
        public static Fraction operator/(Fraction a, Fraction b)
        {
            return new Fraction()
            {
                Numerator = a.Numerator * b.Denominator,
                Denominator = a.Denominator * b.Numerator
            };
        }
        public static bool operator>(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static Fraction operator++(Fraction a)
        {
            return new Fraction()
            {
                Numerator = a.Numerator += a.Denominator,
                Denominator = a.Denominator
            };
        }

        public static bool operator true(Fraction a) 
        { 
            return a.Numerator != 0;
        }
        public static bool operator false(Fraction a)
        {
            return a.Numerator == 0;
        }
    }
}
