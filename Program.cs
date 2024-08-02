using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibraryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Creating instance for 'Book' class with default 'Constructor' ▼
            Book book1 = new Book();
            // ▼ Defining book1 fields. ▼
            book1.bookName = "Adı Aylin";
            book1.authorName = "Ayşe Kulin";
            book1.pageCount = 398;
            book1.publisherName = "Remzi Kitabevi";

            //  Adding book1 to library.
            Book.RegisterBook(book1);

            // ▼ Creating instance with defining fields for using another ctor parameter build ▼
            Book book2 = new Book("Sefiller", "Victor Hugo", 500, "Mert Kitabevi");

            //  Adding book2 to library.
            Book.RegisterBook(book2);

            // ▼ Printing all books in library ▼ 
            foreach (string books in Book.books)
            {
                Console.WriteLine(books);
            }

            /* ▼ Instructions on task -> "Write Class, Property, New and Constructor concepts below of all code ▼ :
             'Class' -> 'Book'
             'Properties' -> In this case I just used fields for no requirement of encapsullation.
             'New' -> For creating instance - new Book()
             'Constructor' -> It works firstly when created Instance of object. new Book()
             */



        }
    }
}
