using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibraryTask
{
    public class Book
    {
        public string bookName;
        public string authorName;
        public string authorSurname;
        public int pageCount;
        public string publisherName;
        public DateTime registerDate;
        public static ArrayList books;
        public static int bookCount;

        static Book()
        {
            books = new ArrayList();
        }

        public Book()
        {
            this.registerDate = DateTime.Now;

        }

        public Book(string bookName, string authorName, int pageCount, string publisherName)
        {
            this.bookName = bookName;
            this.authorName = authorName;
            this.pageCount = pageCount;
            this.publisherName = publisherName;
        }

        public static void RegisterBook(Book book)
        {
            books.Add(book.bookName);
            bookCount++;
        }

    }
}
