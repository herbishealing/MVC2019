using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using primjer_6_2.Models;
namespace primjer_6_2.Controllers
{
    public class MetaDataHtmlHelperiController : Controller
    {
        // GET: MetaDataHtmlHelperi
        public ViewResult MetaDataView()
        {
            return View(new OsobaMeta());
        }
        [HttpPost]
        public ViewResult MetaDataView(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}