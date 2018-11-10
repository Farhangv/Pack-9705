using MVCDemo.Models;
using MVCDemo.Repository;
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
            var repository = new PeopleRepository();
            var people = repository.GetAll();
            ViewData["Users"] = people;
            ViewData["Message"] = "شما میتواند کاربران موجود را در لیست زیر ببینید";

            return View();
        }

        public ActionResult ViewBagDemo()
        {
            var repository = new PeopleRepository();
            var people = repository.GetAll();

            ViewBag.Users = people;
            ViewBag.Message = "شما میتواند کاربران موجود را در لیست زیر ببینید";

            return View();
        }

        public ActionResult ModelDemo()
        {
            var repository = new PeopleRepository();
            var people = repository.GetAll();
            ViewBag.Message = "شما میتواند کاربران موجود را در لیست زیر ببینید";
            return View(people);
        }


    }
}