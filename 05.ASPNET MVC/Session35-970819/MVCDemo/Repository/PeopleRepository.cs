using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Repository
{
    public class PeopleRepository
    {
        public List<Person> GetAll()
        {
            var people = new List<Person>()
            {
                new Person() { Name = "رضا", Family = "رضایی", Age = 30 },
                new Person() { Name = "میترا", Family = "میترایی", Age = 20 },
                new Person() { Name = "پیام", Family = "پیامکی", Age = 25 },
                new Person() { Name = "مریم", Family = "مریمی", Age = 28 }
            };
            return people;
        }

        public bool AddPerson(Person person)
        {
            return true;
        }
    }
}