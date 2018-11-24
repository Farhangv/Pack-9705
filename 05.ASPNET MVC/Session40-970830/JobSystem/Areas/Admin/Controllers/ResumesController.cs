using JobSystem.Models;
using JobSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobSystem.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ResumesController : Controller
    {
        JobDbContext ctx = new JobDbContext();
        public ActionResult Index()
        {
            var resumes = ctx.Resumes
                .OrderByDescending(r => r.ModifiedDate)
                .Select(r => new { r.Id, r.Title, r.User.Name, r.User.Family, r.ModifiedDate, r.FileSize})
                .ToList()
                .Select(r => new ResumeIndexItemViewModel() {
                    Id = r.Id,
                    ModifiedDate = r.ModifiedDate,
                    UserFullName = $"{r.Name} {r.Family}",
                    Title = r.Title,
                    DownloadSize = Convert.ToDouble(r.FileSize) / 1024.0 / 1024.0
                }).ToList();
            return View(resumes);
        }

        public ActionResult Download(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return new HttpStatusCodeResult(400);
            }
            Resume resume = ctx.Resumes.Find(id);
            if (resume == null)
            {
                return new HttpStatusCodeResult(404);
            }
            return File(resume.ResumeFile, resume.MimeType, $"{resume.User.Name}_{resume.User.Family}{Path.GetExtension(resume.OriginalFileName)}");
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
