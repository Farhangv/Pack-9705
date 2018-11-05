using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("Home");
            //return new ContentResult() { Content = "سلام", ContentEncoding = Encoding.UTF8, ContentType = "plain/text" };
        }
        public ActionResult Welcome()
        {
            //return Content("به پروژه ام وی سی خوش آمدید!");
            var person = new Person() { Name = "دانیال", Family = "خامسی" };
            return View(person);
        }

        public ActionResult About()
        {
            return View("~/Views/Home/AboutUs.cshtml");

        }


    }
}