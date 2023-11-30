using System;

namespace Lesson_10.Tumakov
{
    class RationalNumber
    {
        private int numerator;
        private int denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }

        public int Numerator
        {
            get { return numerator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        /// <summary>
        /// Метод для упрощения дроби
        /// </summary>
        private void Simplify()
        {
            int gcd = GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        private int GreatestCommonDivisor(int a, int b) // нод
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static bool operator == (RationalNumber r1, RationalNumber r2)
        {
            return r1.Equals(r2);
        }

        public static bool operator != (RationalNumber r1, RationalNumber r2)
        {
            return !r1.Equals(r2);
        }

        public static bool operator < (RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) < (r2.numerator * r1.denominator);
        }

        public static bool operator > (RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) > (r2.numerator * r1.denominator);
        }

        public static bool operator <= (RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) <= (r2.numerator * r1.denominator);
        }

        public static bool operator >= (RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) >= (r2.numerator * r1.denominator);
        }

        /// <summary>
        /// Оператор сложения
        /// </summary>
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            int commonDenominator = r1.denominator * r2.denominator;
            int sumNumerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            return new RationalNumber(sumNumerator, commonDenominator);
        }

        /// <summary>
        /// Оператор вычитания
        /// </summary>
        public static RationalNumber operator -(RationalNumber rn1, RationalNumber rn2)
        {
            int commonDenominator = rn1.denominator * rn2.denominator;
            int diffNumerator = rn1.numerator * rn2.denominator - rn2.numerator * rn1.denominator;
            return new RationalNumber(diffNumerator, commonDenominator);
        }

        /// <summary>
        /// Оператор умножения
        /// </summary>
        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
        }

        /// <summary>
        /// Оператор деления
        /// <summary>
        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            if (r2.numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return new RationalNumber(r1.numerator * r2.denominator, r1.denominator * r2.numerator);
        }

        /// <summary>
        /// Оператор остатка от деления
        /// </summary>
        public static int operator %(RationalNumber r1, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot take remainder when divisor is zero.");
            }

            int dividend = r1.numerator * r1.denominator;
            return dividend % divisor;
        }

        /// <summary>
        /// Операторы инкремента и декремента
        /// </summary>
        public static RationalNumber operator ++(RationalNumber r)
        {
            return r + new RationalNumber(1, 1);
        }

        public static RationalNumber operator --(RationalNumber r)
        {
            return r - new RationalNumber(1, 1);
        }

        /// <summary>
        /// Операторы преобразования типов
        /// </summary>
        public static implicit operator float(RationalNumber r)
        {
            return (float)r.numerator / r.denominator;
        }

        public static implicit operator int(RationalNumber r)
        {
            return r.numerator / r.denominator;
        }
    }

}
