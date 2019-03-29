using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vjezba2._1_matematicki_izraz.Models;

namespace vjezba2._1_matematicki_izraz.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osoba
        public ActionResult PopuniOsobu()
        {
            return View();
        }
        //POST :Osoba/PopuniOsobu
        [HttpPost]
        public ActionResult PopuniOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}