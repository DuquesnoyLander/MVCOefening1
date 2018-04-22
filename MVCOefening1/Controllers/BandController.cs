using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace MVCOefening1.Controllers
{
    public class BandController : Controller
    {
        private List<Band> bands;
        public BandController()
        {
            bands = BandInitializer.StartUp();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lijst()
        {
            ViewBag.Bands = bands;
            return View();
        }

        public ViewResult LijstMetLeden()
        {
            
            ViewBag.Bands = bands;
            return View();
        }

        public ViewResult Maak(string naam, int? jaar)
        {
            Band NieuweBand = new Band() { Naam = naam ?? "Onbekend", Jaar = jaar ?? DateTime.Now.Year };
            bands.Add(NieuweBand);
            ViewBag.Bands = bands;

            return View("Lijst");
        }
    }
}