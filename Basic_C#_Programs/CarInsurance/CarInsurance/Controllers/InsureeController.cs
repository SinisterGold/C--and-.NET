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
        private InsuranceEntities db = new InsuranceEntities();

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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        public ActionResult CalculateQuote()
        {
            using (InsuranceEntities db = new InsuranceEntities()) //opening connection
            {
                var insurees = db.Insurees; //grabing all data from the table

                var quoteList = new List<Insuree>(); //creating an empty quote list that we pass to the view to display later

                foreach (var insuree in insurees) //iterating threw each entry in out database
                {
                    decimal quote = 50; //Base Price

                    var age = DateTime.Today.Year - insuree.DateOfBirth.Year; //Age calculation using DOB

                    //Age Logic
                    if (age <= 18)
                    {
                        quote += 100;
                    }
                    else if (age >= 19 && age <= 25)
                    {
                        quote += 50;
                    }
                    else //this is for 26 and older
                    {
                        quote += 25;
                    }

                    //Car Year Logic
                    if (insuree.CarYear < 2000)
                    {
                        quote += 25;
                    }
                    else if (insuree.CarYear > 2015) //else if is used here since not every possiablity is covered for example if a can is made from 2001 to 2014 non of the car logic would add anything
                    {
                        quote += 25;
                    }

                    //Car Make Logic
                    if (insuree.CarMake.ToLower() == "porsche")
                    {
                        quote += 25; //amount added for any porsche
                        if (insuree.CarModel.ToLower() == "911 carrera" || insuree.CarModel.ToLower() == "carrera 911")
                        {
                            quote += 25; //additional charge for 911 Carrera
                        }
                    }

                    //Speeding Ticket Logic
                    quote += insuree.SpeedingTickets * 10;

                    //DUI logic
                    if (insuree.DUI)
                    {
                        quote *= 1.25m; //25% increase
                    }

                    //Coverage Logic
                    if (insuree.CoverageType)
                    {
                        quote *= 1.50m; //50% increase if box is ticked
                    }

                    //Saving quote
                    insuree.Quote = quote; //non of the updatign or pass stuff to view makes sense to me
                    
                }
            }
            return View(insuree); //not confident in this at all

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
    }
}
