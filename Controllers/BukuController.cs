using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryWeb.Controllers
{
    public class BukuController : Controller
    {
        // GET: Buku
        public ActionResult Index()
        {
            return View();
        }
    }
}