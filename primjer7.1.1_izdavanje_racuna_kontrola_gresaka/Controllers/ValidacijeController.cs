using primjer7._1._1_izdavanje_racuna_kontrola_gresaka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace primjer7._1._1_izdavanje_racuna_kontrola_gresaka.Controllers
{
    public class ValidacijeController : Controller
    {
        // GET: Validacije
        public ViewResult IzdavanjeRacuna()
        {
            return View(new Racun() {  Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString()});
        }
        [HttpPost]
        public ViewResult IzdavanjeRacuna(Racun racun)
        {
            if (string.IsNullOrEmpty(racun.BrojRacuna))
            {
                ModelState.AddModelError("BrojRacuna", "Broj racuna je obavezan!");
            }
            if(string.IsNullOrEmpty(racun.Zaposlenik))
            {
                ModelState.AddModelError("Zaposlenik", "Zaposlenik je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Kupac))
            {
                ModelState.AddModelError("Kupac", "Kupac je obavezan!");
            }
            if (ModelState.IsValidField("Datum"))
            {
                if (racun.Datum < DateTime.Today.AddDays(-3))
                {
                    ModelState.AddModelError("", "Datum ne smije biti manj od 3 dana!");
                }
            }
            if (ModelState.IsValid)
            {
                return View("Racun izdan", racun);
            }
            else
            {
                return View();
            }
        }

    }
}