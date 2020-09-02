using System;
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
            return View();
        }

        public ActionResult Resultado()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult VerificarPalavraTriangulo(string palavra)
        {
            Services.Funcoes funcoes = new Services.Funcoes();

            ViewBag.Message = "Palavra " + palavra + " => o resultado é " + funcoes.palavraTriangulo(palavra) + ".";

            return View("Resultado");
        }

    }
}