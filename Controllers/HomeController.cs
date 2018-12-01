using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using mojeMVC.Models;

namespace mojeMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string retazec = "retazec";

            ViewBag.Retazec = retazec;

            return View();
        }

        public ActionResult Prva()
        {
            return View();
        }

        public ActionResult Druha()
        {
            string pozdrav = "Ahoj";
            int cislo = 17;

            ViewBag.Pozdrav = pozdrav;
            ViewBag.Cislo = cislo;

            return View();
        }

        public ActionResult Tretia(int id = 2)
        {
            var b = from Book book
                    in Book.GetBooks()
                    where book.Id == id
                    select book;

            ViewBag.Datum = DateTime.Now;

            return View(b);
        }

        public ActionResult Stvrta()
        {
            List<Book> zoznamKnih = Book.GetBooks();

            ViewBag.ZoznamKnih = zoznamKnih;

            return View();
        }
    }
}
