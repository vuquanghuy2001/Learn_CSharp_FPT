using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U040
{
    public class Book
    {
        public int BookId { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "1", Author = "1", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Title = "2", Author = "2", CoverImage = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Title = "3", Author = "3", CoverImage = "Assets/3.jpg" });
            books.Add(new Book { BookId = 4, Title = "4", Author = "4", CoverImage = "Assets/4.jpg" });
            books.Add(new Book { BookId = 5, Title = "5", Author = "5", CoverImage = "Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Title = "6", Author = "6", CoverImage = "Assets/6.jpg" });
            books.Add(new Book { BookId = 7, Title = "7", Author = "7", CoverImage = "Assets/7.jpg" });
            books.Add(new Book { BookId = 8, Title = "8", Author = "8", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookId = 9, Title = "9", Author = "9", CoverImage = "Assets/9.jpeg" });
            books.Add(new Book { BookId = 10, Title = "10", Author = "10", CoverImage = "Assets/10.jpg" });
            books.Add(new Book { BookId = 11, Title = "11", Author = "11", CoverImage = "Assets/11.jpg" });
            books.Add(new Book { BookId = 12, Title = "12", Author = "12", CoverImage = "Assets/12.jpg" });

            return books;
        }
    }
}
