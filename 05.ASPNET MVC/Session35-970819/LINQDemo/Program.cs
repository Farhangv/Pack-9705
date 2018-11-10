using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AWEntities ctx = new AWEntities();
            //var products = from p in ctx.Products
            //               where p.ProductID > 800
            //               select new { p.ProductID, p.Name, p.ListPrice };

            var products = ctx.Products
                //.Where((x) => x.ProductID > 800)
                .Where(x => x.Name.Contains("Headlight"))
                //.Where(ProductsOver800)
                //.Select(p => new { p.ProductID, p.Name, p.ListPrice })
                .Select(p => p)
                //.OrderBy(p => p.Name);
                .OrderByDescending(p => p.Name);
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}. {product.Name} : {product.ListPrice}, {product.ProductSubcategory.Name}, {product.ProductSubcategory.ProductCategory.Name}");
            }

            Console.ReadKey();
        }

        public static bool ProductsOver800(Product p)
        {
            return p.ProductID > 800;
        }
    }
}
