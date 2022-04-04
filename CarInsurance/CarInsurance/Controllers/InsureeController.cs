using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        public InsuranceEntities db = new InsuranceEntities();

        //Admin view that displays first and last name, email, and price for all quotes in db
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            insuree.Quote = CalculateQuote(insuree);
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            insuree.Quote = CalculateQuote(insuree);
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //calculates a quote based off user input
        protected decimal CalculateQuote(Insuree insuree)
        {
            //starting quote of $50
            int baseQuote = 50;

            //multiplier for DUI
            decimal duiPenalty = (decimal)1.25;

            //multiplier for Full Coverage
            decimal fullCoverage = (decimal)1.5;

            //running total to return
            decimal quoteTotal = 0;

            //add the base quote of $50 to the total
            quoteTotal += baseQuote;

            //add modifier based on age
            quoteTotal += AgeModifier(insuree);

            //add $10 per speeding ticket
            quoteTotal += (insuree.SpeedingTickets * 10);

            //add 25 for cars older than '00 or newer than '15
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                quoteTotal += 25;
            }

            //check for Porsche 911
            if (insuree.CarMake == "Porsche")
            {
                quoteTotal += 25;
                if (insuree.CarModel == "911 Carrera")
                {
                    quoteTotal += 25;
                }
            }

            //DUI multiplier
            if (insuree.DUI) { quoteTotal *= duiPenalty; }

            //Full Coverage multiplier
            if (insuree.CoverageType) { quoteTotal *= fullCoverage; }

            return quoteTotal;   
        }

        //calculate additional cost based on age of insuree
        protected int AgeModifier(Insuree insuree)
        {
            //today's date
            var today = DateTime.Today;

            //find insuree's age
            int insureeAge = today.Year - insuree.DateOfBirth.Year;

            //determine bonus fee for insuree age
            if (insureeAge <= 18)
            {
                return 100;
            }
            else if (insureeAge >= 19 && insureeAge < 25)
            {
                return 50;
            }
            else
            {
                return 25;
            }
        }
    }
}
