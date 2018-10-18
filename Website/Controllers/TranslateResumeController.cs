using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class TranslateResumeController : Controller
    {
        private EmploymentDatabase db = new EmploymentDatabase();

        // GET: TranslateResume
        //public ActionResult Index()
        //{
        //    return View(db.Resumes.ToList());
        //}

        // GET: TranslateResume/Details/5
        //public ActionResult Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Resume resume = db.Resumes.Find(id);
        //    if (resume == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(resume);
        //}

        // GET: TranslateResume/Create
        public ActionResult Create(Guid originalResumeId)
        {
            Resume originalResume = db.Resumes.Find(originalResumeId);
            Resume newResume = new Resume()
            {
                OriginalResumeId = originalResumeId,
                OriginalResume = originalResume,
                FirstName = originalResume.FirstName,
                LastName = originalResume.LastName,
                PhoneNumber = originalResume.PhoneNumber,
                Email = originalResume.Email,
            };


            return View(newResume);
        }

        // POST: TranslateResume/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResumeId,FirstName,LastName,PhoneNumber,Email")] Resume resume)
        {
            if (ModelState.IsValid)
            {
                resume.ResumeId = Guid.NewGuid();
                db.Resumes.Add(resume);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resume);
        }

        // GET: TranslateResume/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resume resume = db.Resumes.Find(id);
            if (resume == null)
            {
                return HttpNotFound();
            }
            return View(resume);
        }

        // POST: TranslateResume/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResumeId,FirstName,LastName,PhoneNumber,Email")] Resume resume)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resume).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resume);
        }

        // GET: TranslateResume/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resume resume = db.Resumes.Find(id);
            if (resume == null)
            {
                return HttpNotFound();
            }
            return View(resume);
        }

        // POST: TranslateResume/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Resume resume = db.Resumes.Find(id);
            db.Resumes.Remove(resume);
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
