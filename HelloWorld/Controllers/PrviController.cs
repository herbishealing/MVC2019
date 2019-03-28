using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi/MetodaSParametrima
        public ActionResult MetodaSParametrima(int id)
        {
            // return View();
            return Content(id.ToString());
        }

        // GET : Drugi/MetodaSParametrima/123
        public ViewResult DrugaMetodaSParametrima(int id)
        {
             return View((object)id);
           // return Content(id.ToString());
        }
    }
}