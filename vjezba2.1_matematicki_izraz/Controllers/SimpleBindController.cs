using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vjezba2._1_matematicki_izraz.Controllers
{
    public class SimpleBindController : Controller
    {
        // GET: SimpleBind/SimpleBindMetoda
        public ViewResult SimpleBindMetoda()
        {
            return View("SimpleBind");
        }
        // samo preko akcije i ako akcija ima metodu post
        [HttpPost]
        public ViewResult SimpleBindMetoda(string ime)
        {
            string pozdrav = "Pozdrav," + ime + "!";
            return View("SimpleBind", (object)pozdrav);
        }
    }
}