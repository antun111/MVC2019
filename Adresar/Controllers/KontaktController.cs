using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adresar.Controllers
{
    public class KontaktController : Controller
    {
        // GET: Kontakt
        public ActionResult Index()
        {
            private ApplicationDbContext _db = new ApplicationDbContext();

        List<KontaktController> aktivniKontakti = (from k in _db.Kontakti
                                                   where k.Aktivan
                                                   select k).ToList();
            return View(aktivniKontakti);
        }

    // GET: Kontakt/
    }
}