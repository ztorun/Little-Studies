using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitapKulubu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hakkımızda";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "iletişim";

            return View();
        }
        public ActionResult Activity()
        {
            ViewBag.Message = "Etkinlikler";

            return View();
        }
        public ActionResult Books()
        {
            ViewBag.Message = "Kitaplar";

            return View();
        }
    }
}