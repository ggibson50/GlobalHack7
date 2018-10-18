using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Website.ViewModels;

namespace Website.Controllers
{
    public class BusinessProfileController : Controller
    {
        private EmploymentDatabase db = new EmploymentDatabase();

        //// GET: BusinessProfile
        //public ActionResult Index()
        //{
        //    return View(db.BusinessProfiles.ToList());
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [AllowAnonymous]
        public ActionResult Index(
            string search,
            Guid? industryId,
            int? page,
            int? itemsPerPage)
        {
            IQueryable<BusinessProfile> businessProfiles = db.BusinessProfiles.Include("Industry");

            //Filter the results
            if (industryId != null)
            {
                businessProfiles = businessProfiles.Where(bp => bp.IndustryId == industryId);
            }

            //Search by keyword
            if (!String.IsNullOrWhiteSpace(search))
            {
                businessProfiles = businessProfiles.Where(
                    bp => bp.BusinessName.Contains(search) ||
                         bp.Industry.IndustryName.Contains(search)
                    );
            }

            businessProfiles = businessProfiles.OrderBy(bp => bp.BusinessName);

            //Display the results
            var model = new BusinessProfileSearchResults
            {
                Search = search,
                IndustryId = industryId,
                Industries = db.Industries.OrderBy(i => i.IndustryName).ToList(),
                Results = businessProfiles.ToPagedList(page ?? 1, itemsPerPage ?? 5)
            };

            return View("Index", model);
        }

        // GET: BusinessProfile/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            if (businessProfile == null)
            {
                return HttpNotFound();
            }
            
            return View(businessProfile);
        }

        // GET: BusinessProfile/Create
        [Authorize(Roles = "Business")]
        public ActionResult Create()
        {
            ViewBag.IndustryId = new SelectList(db.Industries, "IndustryId", "IndustryName");
            return View();
        }

        // POST: BusinessProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Business")]
        public ActionResult Create([Bind(Include = "BusinessId,BusinessName,BusinessIndustry,ShortBusinessDescription,LongBusinessDescription,State,City,StreetAddress,EmailAddress,PhoneNumber,Image")] BusinessProfile businessProfile)
        {
            if (ModelState.IsValid)
            {
                db.BusinessProfiles.Add(businessProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IndustryId = new SelectList(db.Industries, "IndustryId", "IndustryName");
            return View(businessProfile);
        }

        // GET: BusinessProfile/Edit/5
        [Authorize(Roles = "Business")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            if (businessProfile == null)
            {
                return HttpNotFound();
            }

            ViewBag.IndustryId = new SelectList(db.Industries, "IndustryId", "IndustryName");
            return View(businessProfile);
        }

        // POST: BusinessProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Business")]
        public ActionResult Edit([Bind(Include = "BusinessId,BusinessName,BusinessIndustry,ShortBusinessDescription,LongBusinessDescription,State,City,StreetAddress,EmailAddress,PhoneNumber,Image")] BusinessProfile businessProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businessProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IndustryId = new SelectList(db.Industries, "IndustryId", "IndustryName");
            return View(businessProfile);
        }

        // GET: BusinessProfile/Delete/5
        [Authorize(Roles = "Business")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            if (businessProfile == null)
            {
                return HttpNotFound();
            }
            return View(businessProfile);
        }

        // POST: BusinessProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Business")]
        public ActionResult DeleteConfirmed(int id)
        {
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            db.BusinessProfiles.Remove(businessProfile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
