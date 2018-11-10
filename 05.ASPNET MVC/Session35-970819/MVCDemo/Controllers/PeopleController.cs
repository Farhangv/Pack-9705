using MVCDemo.Models;
using MVCDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            var repository = new PeopleRepository();
            var people = repository.GetAll();
            return View(people);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Store(FormCollection form)
        //public ActionResult Store(string name, string family, int age)
        public ActionResult Create(Person person)
        {
            var repository = new PeopleRepository();
            //(1)
            //var person = new Person();
            //person.Name = Request["Name"];
            //person.Family = Request.Form["Family"];
            //person.Age = int.Parse(Request.Form["Age"]);

            //(2)
            //var person = new Person();
            //person.Name = form["Name"];
            //person.Family = form["Family"];
            //person.Age = int.Parse(form["Age"]);

            //(3)
            //var person = new Person();
            //person.Name = name;
            //person.Family = family;
            //person.Age = age;

            if (repository.AddPerson(person))
                return Content($"{person} با موفقیت افزوده شده");

            return Content("خطایی در ثبت کاربر به وجود آمده است");
        }
    }
}