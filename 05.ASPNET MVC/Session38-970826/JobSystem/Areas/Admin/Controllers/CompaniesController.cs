using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobSystem.Models;
using JobSystem.ViewModels;

namespace JobSystem.Areas.Admin.Controllers
{
    public class CompaniesController : Controller
    {
        private JobDbContext db = new JobDbContext();

        public ActionResult Index()
        {
            return View(db.Companies.ToList());
        }

        // GET: Admin/Companies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return new HttpStatusCodeResult(400);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                //return HttpNotFound();
                return new HttpStatusCodeResult(404);
            }
            return View(company);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(Company company, HttpPostedFileBase UploadedLogoFile)
        public ActionResult Create(CompaniesCreateViewModel viewModel)
        {
            //var file = Request.Files["UploadedLogoFile"];
            var logoSize = viewModel.UploadedLogoFile.ContentLength / 1024;
            var extension = Path.GetExtension(viewModel.UploadedLogoFile.FileName).ToLower();

            if (logoSize > 500)
            {
                ModelState.AddModelError("UploadedLogoFile", "حجم فایل ارسالی نباید بیش از ۵۰۰ کیلو بایت باشد");
            }
            if (extension != ".jpg" && extension != ".png" && extension != ".gif" && extension != ".jpeg")
            {
                ModelState.AddModelError("UploadedLogoFile", "فایل ارسالی شما باید یک عکس باشد");
            }

            if (ModelState.IsValid)
            {
                Company company = new Company();
                company.Name = viewModel.Name;
                company.Website = viewModel.Website;
                company.CellPhone = viewModel.CellPhone;
                company.Description = viewModel.Description;
                company.Email = viewModel.Email;
                //File
                //var path = $"~/Images/Logos/{Guid.NewGuid()}{extension}";
                var fileName = $"{Guid.NewGuid()}{extension}";
                var path = Path.Combine(Server.MapPath("~/Images/Logos/"), fileName);
                //viewModel.UploadedLogoFile.SaveAs(path);
                viewModel.UploadedLogoFile.SaveAs(path);

                company.LogoFilePath = fileName;

                db.Companies.Add(company);
                db.SaveChanges();
                TempData["Message"] = "شرکت با موفقیت افزوده شد";
                TempData["MessageClass"] = "success";

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(company).State = EntityState.Modified;
                //Company db_company = db.Companies.Find(company.Id);
                //db_company.Name = company.Name;
                //db_company.CellPhone = company.CellPhone;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Admin/Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
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
