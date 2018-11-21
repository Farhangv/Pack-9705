using JobSystem.Models;
using JobSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobSystem.Controllers
{
    public class HomeController : Controller
    {
        JobDbContext ctx = new JobDbContext();
        public ActionResult Index(string search)
        {
            var jobs = ctx.Jobs
            //.Where(j => j.Title.Contains(search))
            .Select(j => new JobIndexItemViewModel()
            {
                Id = j.Id,
                Title = j.Title,
                CompanyLogoPath = j.Company.LogoFilePath,
                CompanyName = j.Company.Name
            }).ToList();
            return View(jobs);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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