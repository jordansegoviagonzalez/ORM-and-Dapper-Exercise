using ORM_Dapper.Models;

namespace ORM_Dapper.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}