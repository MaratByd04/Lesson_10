namespace Lesson_10.Tumakov
{
    class ComplexNumber
    {
        private double real;
        private double imaginary;

        // Конструктор для инициализации комплексного числа
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Перегрузил оператор сложения 
        public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2)
        {
            return new ComplexNumber(cn1.real + cn2.real, cn1.imaginary + cn2.imaginary);
        }

        // Перегрузил оператор вычитания
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }

        // Перегрузил оператор умножения
        public static ComplexNumber operator *(ComplexNumber cn1, ComplexNumber cn2)
        {
            double realPart = cn1.real * cn2.real - cn1.imaginary * cn2.imaginary;
            double imaginaryPart = cn1.real * cn2.imaginary + cn1.imaginary * cn2.real;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Перегрузил оператор равенства
        public static bool operator == (ComplexNumber cn1, ComplexNumber cn2)
        {
            return cn1.real == cn2.real && cn1.imaginary == cn2.imaginary;
        }

        // Перегрузил оператор неравенства
        public static bool operator != (ComplexNumber cn1, ComplexNumber cn2)
        {
            return !(cn1 == cn2);
        }

        // Переопределение метода ToString()
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }

}
