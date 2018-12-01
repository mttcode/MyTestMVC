using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mojeMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Id = 1, Name = "Nazov_1", Author = "Autor_1" });
            books.Add(new Book() { Id = 2, Name = "Nazov_2", Author = "Autor_2" });
            books.Add(new Book() { Id = 3, Name = "Nazov_3", Author = "Autor_3" });

            return books;
        }
    }
}
