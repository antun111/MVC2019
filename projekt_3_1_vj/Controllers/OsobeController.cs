﻿using projekt_3_1_vj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_3_1_vj.Controllers
{
    public class OsobeController : Controller
    {
        // GET: Osobe
        public ViewResult PopuniOsobu()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PrikaziOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}