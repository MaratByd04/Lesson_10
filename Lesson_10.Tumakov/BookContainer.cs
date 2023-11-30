using System;
using System.Collections.Generic;

namespace Lesson_10.Tumakov
{
    class BookContainer
    {
        // Делегат 
        public delegate int BookComparisonDelegate(Book book1, Book book2);
        // делегат

        private List<Book> books = new List<Book>();

        // Метод для добавления книги в контейнер
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Метод для сортировки книг 
        public void SortBooks(BookComparisonDelegate comparisonDelegate)
        {
            books.Sort((book1, book2) => comparisonDelegate(book1, book2));
        }

        // Метод для вывода списка книг
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Заголовок: {book.title}, Автор: {book.author}, Издатель: {book.publisher}");
            }
        }
    }
}
