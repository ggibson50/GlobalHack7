using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Website.ViewModels;
using System.Data.Entity.Migrations;

namespace Website.Controllers
{
    public class ResumeSkillController : Controller
    {
        public EmploymentDatabase db = new EmploymentDatabase();

        [HttpGet]
        public ActionResult Edit(Guid? resumeId)
        {
            ViewBag.ResumeId = resumeId;

            var aquiredSkills = (
                from s in db.ResumeSkills
                where s.ResumeId == resumeId
                select s.SkillCategoryId
            ).ToList();

            var categories =
                from c in db.SkillCategory
                orderby c.SkillType, c.SkillCategoryName
                select new JobSkillInfo
                {
                    JobSkillId = c.SkillId,
                    SkillType = c.SkillType,
                    SkillCategory = c.SkillCategoryName,
                    Image = c.Image,
                    Checked = aquiredSkills.Contains(c.SkillId)
                };

            return View(categories.ToList());
        }

        [HttpPost]
        public ActionResult Edit(Guid resumeId, IEnumerable<JobSkillInfo> skills)
        {
            if (ModelState.IsValid)
            {
                // Remove rows from ResumeSkill
                // Add rows to ResumeSkill
                foreach (var item in skills.Where(s => s.Checked))
                {
                    db.ResumeSkills.AddOrUpdate(new ResumeSkill
                    {
                        ResumeId = resumeId,
                        SkillCategoryId = item.JobSkillId
                    });
                }
                // Save changes
                db.SaveChanges();
                return RedirectToAction("Edit", "Resume", new { id = resumeId });
            }
            ViewBag.ResumeId = resumeId;
            return View(skills.ToList());
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