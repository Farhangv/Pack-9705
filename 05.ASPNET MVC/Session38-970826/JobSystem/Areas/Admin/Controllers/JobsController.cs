using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobSystem.Models;

namespace JobSystem.Areas.Admin.Controllers
{
    public class JobsController : Controller
    {
        private JobDbContext ctx = new JobDbContext();

        // GET: Admin/Jobs
        public ActionResult Index()
        {
            var jobs = ctx.Jobs.Include(j => j.Company);
            return View(jobs.ToList());
        }

        // GET: Admin/Jobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = ctx.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: Admin/Jobs/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(ctx.Companies, "Id", "Name");
            return View();
        }

        // POST: Admin/Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,ValidDate,Location,Count,Wage,CompanyId")] Job job)
        {
            if (ModelState.IsValid)
            {
                ctx.Jobs.Add(job);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(ctx.Companies, "Id", "Name", job.CompanyId);
            return View(job);
        }

        // GET: Admin/Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = ctx.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(ctx.Companies, "Id", "Name", job.CompanyId);
            return View(job);
        }

        // POST: Admin/Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,ValidDate,Location,Count,Wage,CompanyId")] Job job)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(job).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(ctx.Companies, "Id", "Name", job.CompanyId);
            return View(job);
        }

        // GET: Admin/Jobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = ctx.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Admin/Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = ctx.Jobs.Find(id);
            ctx.Jobs.Remove(job);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
