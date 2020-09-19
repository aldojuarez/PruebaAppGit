using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAppGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ESTA ES LA DESCRIPCION DE MI PAGINA";
            ViewBag.Suma = 15;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MI NOMBRE ES ALDO JUAREZ";

            return View();
        }
    }
}