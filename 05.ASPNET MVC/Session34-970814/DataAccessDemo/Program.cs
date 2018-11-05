using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessDemo
{
    class Program
    {
        static void Main(string[] args)//ASP.NET
        {
            var products = (new ProductRepository()).GetAll();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.Color} : {product.ProductId}");
            }
            Console.ReadKey();
        }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }

    public class ProductRepository//Data Access
    {
        public List<Product> GetAll()
        {
            SqlConnection conn = new SqlConnection("server=.;database=AdventureWorks;uid=sa;pwd=developer;");
            SqlCommand cmd = new SqlCommand("SELECT ProductId, Name, Color FROM Production.Products", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                products.Add(new Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    Name = reader["Name"].ToString(),
                    Color = reader["Color"].ToString()
                });
            }

            return products;
        }
    }

}
