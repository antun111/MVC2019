using projekt_6_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace projekt_6_2.Controllers
{
    public class MetaDataHtmlHelperController : Controller
    {
        // GET: MetaDataHtmlHelper
        public ActionResult MetaDataView()
        {
            return View(new OsobaMeta());
        }
        [HttpPost]
        public ActionResult MetaDataView(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}