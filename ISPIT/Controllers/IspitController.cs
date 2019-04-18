using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISPIT.Controllers
{
    public class IspitController : Controller
    {
        // GET: Ispit
        public string Prvi()
        {
            
            DateTime dateStamp = HttpContext.Timestamp;

            return "<h2>Danasnji datum i vrijeme:</h2>" + dateStamp;
        }
    }
}