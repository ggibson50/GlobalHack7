using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Website.ViewModels;

namespace Website.Controllers
{
    [Authorize(Roles = "Admin")]
    public class JobSkillController : Controller
    {
        private EmploymentDatabase db = new EmploymentDatabase();

        // GET: JobSkill
        public ActionResult Index()
        {
            var query =
                from j in db.JobSkill
                join c in db.SkillCategory on j.SkillCategory equals c.SkillCategoryName
                orderby j.SkillType, j.SkillCategory, j.JobSkillName
                select new JobSkillInfo
                {
                    JobSkillId = j.JobSkillId,
                    SkillType = j.SkillType,
                    SkillCategory = j.SkillCategory,
                    JobSkillName = j.JobSkillName,
                    Image = c.Image
                };

            return View(query.ToList());
        }

        // GET: JobSkill/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSkill jobSkill = db.JobSkill.Find(id);
            if (jobSkill == null)
            {
                return HttpNotFound();
            }
            return View(jobSkill);
        }

        // GET: JobSkill/Create
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobSkillId,JobSkillName,SkillType,SkillCategory")] JobSkill jobSkill)
        {
            if (ModelState.IsValid)
            {
                jobSkill.JobSkillId = Guid.NewGuid();
                db.JobSkill.Add(jobSkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobSkill);
        }

        // GET: JobSkill/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSkill jobSkill = db.JobSkill.Find(id);
            if (jobSkill == null)
            {
                return HttpNotFound();
            }
            return View(jobSkill);
        }

        // POST: JobSkill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobSkillId,JobSkillName,SkillType,SkillCategory")] JobSkill jobSkill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobSkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobSkill);
        }

        // GET: JobSkill/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSkill jobSkill = db.JobSkill.Find(id);
            if (jobSkill == null)
            {
                return HttpNotFound();
            }
            return View(jobSkill);
        }

        // POST: JobSkill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            JobSkill jobSkill = db.JobSkill.Find(id);
            db.JobSkill.Remove(jobSkill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                db = null;
            }
            base.Dispose(disposing);
        }
    }
}
