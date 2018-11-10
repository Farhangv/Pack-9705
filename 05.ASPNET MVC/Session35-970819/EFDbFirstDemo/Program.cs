using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD
            //R
            var ctx = new AWEntities();
            var productsSet = ctx.Products;
            //var products = productsSet.ToList();
            //var p = productsSet.ToArray();
            //p[0].Name = "Edited Product";
            //ctx.SaveChanges();
            //productsSet.First();
            //productsSet.FirstOrDefault();



            foreach (var product in productsSet)
            {
                Console.WriteLine(product);
            }

            //--------------------------------
            //C
            //PeopleEntities ctx = new PeopleEntities();
            //Console.WriteLine("Please Enter Name, Family, Age");
            //ctx.People.Add(
            //    new Person()
            //{
            //    Name = Console.ReadLine(),
            //    Family = Console.ReadLine(),
            //    Age = int.Parse(Console.ReadLine())
            //});

            //ctx.SaveChanges();

            //U
            //PeopleEntities ctx = new PeopleEntities();
            //var person = ctx.People.Find(1);
            //person.Name = "David";
            //ctx.SaveChanges();

            //D
            //PeopleEntities ctx = new PeopleEntities();
            //ctx.People.Remove(ctx.People.Find(1));
            //ctx.SaveChanges();

            //Console.ReadKey();
        }
    }
}
