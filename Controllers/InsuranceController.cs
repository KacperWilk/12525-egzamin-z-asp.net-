using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkladkaUbezpieczenie.Models;

namespace SkladkaUbezpieczenie.Controllers
{
    public class InsuranceController : Controller
    {
        private static IList<Insurance> insurances = new List<Insurance>()
        {
            new Insurance()
                {Id = 1,Email = "kacper.wilk@wsei.pl", BirthDate = new DateTime(2001, 12, 13), Price = 1000, YearlyLength = 3}
        };
        // GET: Insurance
        public ActionResult Index()
        {
            return View(insurances);
        }

        public ActionResult Create()
        {
            return View(new Insurance());
        }
        [HttpPost]
        public ActionResult Create(Insurance insurance)
        {
            insurance.Id = insurances.Count + 1;
            insurances.Add(insurance);
            return RedirectToAction("Details", new { id = insurance.Id });
        }

        public ActionResult Details(int id)
        {
            return View(insurances.FirstOrDefault(x => x.Id == id));
        }

    }
}