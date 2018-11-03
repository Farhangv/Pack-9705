using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Razor()
        {
            return View();
        }

        public ActionResult ViewDataDemo()
        {
            var people = new List<Person>()
            {
                new Person() { Name = "رضا", Family = "رضایی", Age = 30 },
                new Person() { Name = "میترا", Family = "میترایی", Age = 20 },
                new Person() { Name = "پیام", Family = "پیامکی", Age = 25 },
                new Person() { Name = "مریم", Family = "مریمی", Age = 28 }
            };

            ViewData["Users"] = people;
            ViewData["Message"] = "شما میتواند کاربران موجود را در لیست زیر ببینید";

            return View();
        }
    }
}