using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_5_3_vj.Controllers
{
    public class ParcijalniPoglediController : Controller
    {
        // GET: ParcijalniPogledi
        public ViewResult PrikaziKosaricu()
        {
            List<Artikal> ListaArtikala = new List<Artikal>()
            {
                new Artikal(){ Cijena=9.99m, Kategorija="plava", Kolicina=5, Naziv="Keks"},
                new Artikal(){ Cijena=8.99m, Kategorija="zelena", Kolicina=7, Naziv="Kifla"},
                new Artikal(){ Cijena=6.99m, Kategorija="zuta", Kolicina=20, Naziv="Kroki"}
            };
            return View(ListaArtikala);
        }
    }

    internal class Artikal
    {
    }
}