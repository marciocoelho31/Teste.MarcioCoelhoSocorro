﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Página de Sobre.";

            return View();
        }

        public ActionResult Resultado()
        {
            ViewBag.Message = "Página de Resultado.";

            return View();
        }
    }
}