using JobSystem.Models;
using JobSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobSystem.Controllers
{
    [Authorize]
    public class ResumesController : Controller
    {
        private JobDbContext ctx = new JobDbContext();
        public ActionResult Edit()
        {
            var username = User.Identity.Name;
            var resume = ctx.Resumes.Where(r => r.User.UserName == username).FirstOrDefault();
            var viewModel = new ResumesEditViewModel()
            {
                Title = resume?.Title
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ResumesEditViewModel viewModel)
        {
            
            var userName = User.Identity.Name;

            //TODO: File Validation
            if (ModelState.IsValid)
            {
                Resume resume;
                resume = ctx.Resumes.Where(r => r.User.UserName == userName).FirstOrDefault();
                var newResume = false;
                if (resume == null)
                {
                    resume = new Resume();
                    newResume = true;
                }
                resume.Title = viewModel.Title;
                //تبدیل فایل به داده باینری
                using (MemoryStream ms = new MemoryStream(viewModel.UploadedResumeFile.ContentLength))
                {
                    viewModel.UploadedResumeFile.InputStream.CopyTo(ms);
                    resume.ResumeFile = ms.ToArray();
                }
                resume.OriginalFileName = viewModel.UploadedResumeFile.FileName;
                resume.FileSize = viewModel.UploadedResumeFile.ContentLength;
                resume.MimeType = viewModel.UploadedResumeFile.ContentType;
                resume.User = ctx.Users.Where(u => u.UserName == userName).FirstOrDefault();

                if (newResume)
                {
                    ctx.Resumes.Add(resume);
                }
                resume.ModifiedDate = DateTime.Now;
                ctx.SaveChanges();
                TempData["Message"] = "رزومه شما با موفقیت به روز شد";
                
                return RedirectToAction("Index", "Home");
            }
            TempData["Message"] = "خطایی در به روز رسانی رزومه اتفاق افتاده";
            TempData["MessageClass"] = "danger";
            return View(viewModel);
        }
    }
}