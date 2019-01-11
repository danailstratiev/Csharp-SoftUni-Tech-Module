using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;



namespace Exercise_5_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> myBooks = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.RealeaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture) ;
                book.ISBN = input[4];
                book.Price = double.Parse(input[5]);

                myBooks.Add(book);
            }

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.GroupBy(x => x.Author).OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(x=> x.Key))
            {
                // Author след GroupBy става Key в ThenBy
                Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):F2}");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public List<Book> Books { get; set; }
        public string Name { get; set; }
    }
}
