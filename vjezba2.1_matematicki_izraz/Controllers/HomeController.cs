using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vjezba2._1_matematicki_izraz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string message = "rezultat operacije 4 + 3 * 3 = ";
            return View((object)message);
        }
    }
}