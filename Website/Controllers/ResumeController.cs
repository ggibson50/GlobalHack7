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
    [Authorize]
    public class ResumeController : Controller
    {
        private EmploymentDatabase db = new EmploymentDatabase();

        // GET: Resume
        //[Authorize(Roles = "Admin, Translator")]
        public ActionResult Index()
        {
            return View(db.Resumes.ToList());
        }

        // GET: Resume/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkResults workResults = new WorkResults();
            workResults.Resume = db.Resumes.Find(id);
            if (workResults.Resume == null)
            {
                return HttpNotFound();
            }
            workResults.WorkExperiences = db.WorkExperiences.Where(x => x.ResumeId == id).ToList();
            return View(workResults);
        }

        // GET: Resume/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resume/Create
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

        // GET: Resume/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkResults workResults = new WorkResults();
            workResults.Resume = db.Resumes.Find(id);
            if (workResults.Resume == null)
            {
                return HttpNotFound();
            }
            List<WorkExperience> workExperiences = db.WorkExperiences.Where(x => x.ResumeId == id).ToList();
            workResults.WorkExperiences = workExperiences;
            
            //var query =
            //  from c in db.SkillCategory
            //  join rs in db.ResumeSkills on j.JobSkillId equals rs.SkillCategoryId
            //  where rs.ResumeId == id
            //  orderby j.SkillType, j.SkillCategory, j.JobSkillName
            //  select new JobSkillInfo
            //  {
            //      JobSkillId = j.JobSkillId,
            //      SkillType = j.SkillType,
            //      SkillCategory = j.SkillCategory,
            //      JobSkillName = j.JobSkillName,
            //      Image = c.Image
            //  };
            //workResults.JobSkillInfos = query.ToList();

            workResults.SkillCategories = db.SkillCategory.ToList();
            workResults.AquiredSkills = (
                from s in db.ResumeSkills
                where s.ResumeId == id
                select s.SkillCategoryId
            ).ToList();
            return View(workResults);
        }

        // POST: Resume/Edit/5
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

        // GET: Resume/Delete/5
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

        // POST: Resume/Delete/5
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
