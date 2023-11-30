using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10.Tumakov
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Домашнее задание 12.1");
            Console.ForegroundColor = ConsoleColor.White;

            ComplexNumber complex1 = new ComplexNumber(5, 13);
            ComplexNumber complex2 = new ComplexNumber(3, 20);

            ComplexNumber sum = complex1 + complex2;
            ComplexNumber difference = complex1 - complex2;
            ComplexNumber product = complex1 * complex2;

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {difference}");
            Console.WriteLine($"Произведение: {product}");

            Console.WriteLine($"Они равны? {complex1 == complex2}");
            Console.WriteLine($"Они неравны? {complex1 != complex2}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nДомашнее задание 12.2");
            Console.ForegroundColor = ConsoleColor.White;

            BookContainer bookContainer = new BookContainer();

            bookContainer.AddBook(new Book("Онегин", "А.С.Пушкин", "Русское издательство"));
            bookContainer.AddBook(new Book("Принц Терний", "М.Лоуренс", "Американское издательство"));
            bookContainer.AddBook(new Book("Ведьмак", "А.Сапковский", "Польское издательство"));

            Console.WriteLine("Сортировака по заголовку:");
            bookContainer.SortBooks((book1, book2) => String.Compare(book1.title, book2.title));
            bookContainer.DisplayBooks();

            Console.WriteLine("\nСортировка по автору:");
            bookContainer.SortBooks((book1, book2) => String.Compare(book1.author, book2.author));
            bookContainer.DisplayBooks();

            Console.WriteLine("\nСортировка по издателю:");
            bookContainer.SortBooks((book1, book2) => String.Compare(book1.publisher, book2.publisher));
            bookContainer.DisplayBooks();

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\nУпражненеие 12.2");
            Console.ForegroundColor = ConsoleColor.White;

            RationalNumber rn1 = new RationalNumber(1, 2);
            RationalNumber rn2 = new RationalNumber(3, 4);

            Console.WriteLine($"Первое число: {rn1}");
            Console.WriteLine($"Второе число: {rn2}");

            Console.WriteLine($"Первое число + второе число: {rn1 + rn2}");
            Console.WriteLine($"Первое число - второе число: {rn1 - rn2}");
            Console.WriteLine($"Первое число * второе число: {rn1 * rn2}");
            Console.WriteLine($"Первое число / второе число: {rn1 / rn2}");
            Console.WriteLine($"Первое число % 3: {rn1 % 3}");

            Console.WriteLine($"Первое число == второе число: {rn1 == rn2}");
            Console.WriteLine($"Первое число != второе число: {rn1 != rn2}");
            Console.WriteLine($"Первое число < второе число: {rn1 < rn2}");
            Console.WriteLine($"Первое число > второе число: {rn1 > rn2}");
            Console.WriteLine($"Первое число <= второе число: {rn1 <= rn2}");
            Console.WriteLine($"Первое число >= второе число: {rn1 >= rn2}");

            Console.WriteLine($"++Первое число: {++rn1}");
            Console.WriteLine($"--Второе число: {--rn2}");

            // Операторы преобразования типов
            float floatResult = rn1;
            int intResult = rn2;

            Console.WriteLine($"Результат с типом Float: {floatResult}");
            Console.WriteLine($"Результат с типом Int: {intResult}\n");
        }
    }
}
