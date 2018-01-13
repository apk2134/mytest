using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookEntity;
using BookRentBL;
namespace BookRent.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult search()
        {
            return View();
        }

        public ActionResult order()
        {
            return View();
        }

        public ActionResult subscribe()
        {
            return View();
        }
        public ActionResult Author()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Author(Author author)
        {
            AuthorManager manager = new AuthorManager();
            manager.CreateAuthor(author);
            return View();

        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Book(Author author, Book book, Category category)
        {
            Manager bookadd = new Manager();
            bookadd.Createitems(author, book, category);
            return View();
        }
    }
}