using JobSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JobSystem.Controllers
{
    public class JobsController : Controller
    {
        JobDbContext ctx = new JobDbContext();
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var job = ctx.Jobs.Find(id);
            if (job == null)
                return HttpNotFound();



            return View(job);
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