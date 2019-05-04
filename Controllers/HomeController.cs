using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using mojeMVC.Models;

namespace myMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string myString = "string";

            ViewBag.Retazec = myString;

            return View();
        }

        public ActionResult First()
        {
            return View();
        }

        public ActionResult Second()
        {
            string greeting = "Hello";
            int number = 17;

            ViewBag.Greeting = greeting;
            ViewBag.Number = number;

            return View();
        }

        public ActionResult Third(int id = 2)
        {
            var b = from Book book
                    in Book.GetBooks()
                    where book.Id == id
                    select book;

            ViewBag.Date = DateTime.Now;

            return View(b);
        }

        public ActionResult Fourth()
        {
            List<Book> ListBooks = Book.GetBooks();

            ViewBag.ListBooks = ListBooks;

            return View();
        }
    }
}
