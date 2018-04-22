using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace MVCOefening1.Controllers
{
    public class BandLidController : Controller
    {
        private List<Band> bands;

        public BandLidController()
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

        public IActionResult Maak(string naam, Geslacht? geslacht, string band)
        {
            bands.Add(
                new Band()
                {
                    Naam = band ?? "Onbekend",
                    Leden = new List<BandLid>()
                    {
                        new BandLid()
                        {
                            Naam = naam ?? "Onbekend",
                            Leeftijd = DateTime.Now.Year,
                            Geslacht = geslacht ?? Geslacht.Man }
                    }
                });
            ViewBag.Bands = bands;
            return View("Lijst");
        }
    }
}