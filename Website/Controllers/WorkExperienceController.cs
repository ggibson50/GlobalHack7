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
    public class WorkExperienceController : Controller
    {
        private EmploymentDatabase db = new EmploymentDatabase();

        // GET: WorkExperience
        public ActionResult Index()
        {
            return View(db.WorkExperiences.ToList());
        }

        // GET: WorkExperience/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperience workExperience = db.WorkExperiences.Find(id);
            if (workExperience == null)
            {
                return HttpNotFound();
            }
            return View(workExperience);
        }

        // GET: WorkExperience/Create
        public ActionResult Create(Guid? resumeId)
        {
            if(resumeId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperience workExperience = new WorkExperience { ResumeId = resumeId.Value };
            return View(workExperience);
        }

        // POST: WorkExperience/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkExperienceId,ResumeId,BusinessName,StartDate,EndDate,JobTitle,Description")] WorkExperience workExperience)
        {
            if (ModelState.IsValid)
            {
                workExperience.WorkExperienceId = Guid.NewGuid();
                db.WorkExperiences.Add(workExperience);
                db.SaveChanges();
                return RedirectToAction("Edit", "Resume", new { id = workExperience.ResumeId });
            }

            return View(workExperience);
        }

        // GET: WorkExperience/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperience workExperience = db.WorkExperiences.Find(id);
            if (workExperience == null)
            {
                return HttpNotFound();
            }
            return View(workExperience);
        }

        // POST: WorkExperience/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkExperienceId,ResumeId,BusinessName,StartDate,EndDate,JobTitle,Description")] WorkExperience workExperience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workExperience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "Resume", new { id = workExperience.ResumeId });
            }
            return View(workExperience);
        }

        // GET: WorkExperience/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperience workExperience = db.WorkExperiences.Find(id);
            if (workExperience == null)
            {
                return HttpNotFound();
            }
            return View(workExperience);
        }

        // POST: WorkExperience/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            WorkExperience workExperience = db.WorkExperiences.Find(id);
            db.WorkExperiences.Remove(workExperience);
            db.SaveChanges();
            return RedirectToAction("Edit", "Resume", new { id = workExperience.ResumeId });
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
