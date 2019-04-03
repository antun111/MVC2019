using projekt_5_3_vj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_5_3_vj.Controllers
{
    public class HtmlHelperiController : Controller
    {
        // GET: HtmlHelperi
        public ActionResult Index()
        {
            return View();
        }

        private string[] mjesta = new string[] { "Split", "Osijek", "Rijeka", "Zagreb" };

        public ViewResult FormHelper()
        {
            ViewBag.Mjesta = mjesta;
            return View(new Osoba());
        }

        [HttpPost]
        public ViewResult FormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = this.mjesta;
            ViewBag.Poruka = "podaci uneseni!";
            return View(new Osoba());
        }
    }
}