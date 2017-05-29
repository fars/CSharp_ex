using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public delegate void doSmthWithBooks(Book book);


    public class Book
    {
        public Book (string title, string author, int pageCount, decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            Price = price;
            PaperBack = paperBack;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public bool PaperBack { get; set; }
    }

    class BookDataBase
    {
        private List<Book> _bookList = new List<Book>();

        public void AddBook(Book book)
        {
            _bookList.Add(book);
        }

        public void ProcessBooks(doSmthWithBooks process)
        {
            foreach (var book in _bookList)
            {
                process(book);
            }
        }

    }

    public class BooksValueCounter
    {
        private decimal _totalPrice = 0.0M;
        private int _booksCount = 0;
        private void AddBook(Book b)
        {
            _booksCount++;
            _totalPrice += b.Price;
        }

        public decimal ReturnAvarege()
        {
            return _totalPrice/_booksCount;
        }

        public void CalculateTotal(Book book)
        {
            AddBook(book);
        }
    }

    class Program
    {
        static void PrintBookTitle(Book b)
        {
            Console.WriteLine(b.Title);
        }

        static void PrintBookAuthor(Book b)
        {
            Console.WriteLine(b.Author);
        }

        static void Main(string[] args)
        {
            Book book1 = new Book("Alice in wonderland", "Luice Carrol", 300, 20.99M, true);
            Book book2 = new Book("Spectr", "Lukyanenko Sergey", 300, 9.99M, true);
            Book book3 = new Book("Dark tower", "King", 300, 10.99M, true);
            Book book4 = new Book("Lone in the dark", "Sergey", 300, 30.99M, true);

            BookDataBase bookDb = new BookDataBase();

            bookDb.AddBook(book1);
            bookDb.AddBook(book2);
            bookDb.AddBook(book3);
            bookDb.AddBook(book4);

            bookDb.ProcessBooks(PrintBookTitle);

            BooksValueCounter calc = new BooksValueCounter();

            bookDb.ProcessBooks(calc.CalculateTotal);

            Console.WriteLine(calc.ReturnAvarege());

            doSmthWithBooks writeAuthor = new doSmthWithBooks(PrintBookAuthor);
            doSmthWithBooks writeTitle = new doSmthWithBooks(PrintBookTitle);
            doSmthWithBooks writeCalc = new doSmthWithBooks(calc.CalculateTotal);

            doSmthWithBooks combo = writeCalc + writeAuthor + writeTitle;

            bookDb.ProcessBooks(combo);



        }
    }
}
