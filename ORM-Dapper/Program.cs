using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper.Data;

namespace ORM_Dapper
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var configuration  = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            IDbConnection connection = new MySqlConnection(connectionString);

            var productRepository = new ProductRepository(connection);

            var products = productRepository.GetAllProducts();

            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID} | Name: {product.Name} | Price: {product.Price} | Category: {product.CategoryID} | Sale: {product.OnSale} | Stock: {product.ProductID}"); 
            }
        }
    }
}
