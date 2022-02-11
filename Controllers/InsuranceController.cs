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
            return RedirectToAction("Details", new { id = insurance.Id, email = insurance.Email, birthdate = insurance.BirthDate, price = insurance.Price, yearlylength = insurance.YearlyLength });

        }
        public ActionResult Confirm(int id, string email, DateTime birthdate, double price, double yearlylength)
        {
            Insurance toConfirmInsurance = new Insurance()
                {Id = id, Email = email, BirthDate = birthdate, Price = price, YearlyLength = yearlylength};
            insurances.Add(toConfirmInsurance);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id, string email, DateTime birthdate, double price, double yearlylength)
        {
            ViewBag.id = id;
            ViewBag.email = email;
            ViewBag.birthdate = birthdate;
            ViewBag.price = price;
            ViewBag.yearlylength = yearlylength;
            return View("Details");
        }

    }
}