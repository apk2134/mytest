using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}