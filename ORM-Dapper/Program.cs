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
            var connectionString = configuration.GetConnectionString("bestbuy");
            //fixed string connection to the proper data type 

            IDbConnection connection = new MySqlConnection(connectionString);

            var productRepository = new ProductRepository(connection);

            var products = productRepository.GetAllProducts();
            
            var departmentRepo = new DapperDepartmentRepository(connection);
            
            departmentRepo.InsertDerpartment("John's New Department");
            
            
            
            var deparments = departmentRepo.GetAllDepartments();

            foreach (var deparment in deparments)
            {
                Console.WriteLine(deparment.DepartmentID);
                Console.WriteLine(deparment.Name);
                Console.WriteLine();
                Console.WriteLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID} | Name: {product.Name} | Price: {product.Price} | Category: {product.CategoryID} | Sale: {product.OnSale} | Stock: {product.ProductID}"); 
            }
        }
    }
}
