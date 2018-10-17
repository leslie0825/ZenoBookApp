using BusinessEngine;
using Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenoBookApp.Models;

namespace ZenoBookApp.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get()
        {
            BooksEngine booksEngine = new BooksEngine();
            var books = booksEngine.GetBooks();
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Post(string bookName, string genre)
        {
            BooksEngine booksEngine = new BooksEngine();
            booksEngine.InsertBook(new InsertBookDTO { AuthorId = 1, BookName = bookName, Genre = genre });
        }

        public ActionResult search(string bookName)
        {
            BooksEngine booksEngine = new BooksEngine();
            var books = booksEngine.SearchBooks(bookName);
            return Json(books, JsonRequestBehavior.AllowGet);
        }


    }
}