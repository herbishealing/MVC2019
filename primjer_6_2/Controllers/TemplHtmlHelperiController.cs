﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using primjer_6_2.Models;

namespace primjer_6_2.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ViewResult HtmlEditorView()
        {
            return View(new OsobaTempl());
        }
        [HttpPost]
        public ViewResult HtmlEditorView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
        public ViewResult EditorModelView()
        {
            return View(new OsobaTempl());
        }
        [HttpPost]
        public ViewResult EditorModelView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}