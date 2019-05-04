using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Id = 1, Name = "Name_1", Author = "Author_1" });
            books.Add(new Book() { Id = 2, Name = "Name_2", Author = "Author_2" });
            books.Add(new Book() { Id = 3, Name = "Name_3", Author = "Author_3" });

            return books;
        }
    }
}
