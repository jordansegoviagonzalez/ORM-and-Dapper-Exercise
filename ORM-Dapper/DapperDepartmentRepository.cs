using System.Data;
using Dapper;

namespace ORM_Dapper;

public class DapperDepartmentRepository : IDepartmentRepository
{
    private readonly IDbConnection _conn;

    public DapperDepartmentRepository(IDbConnection conn)
    {
        _conn = conn;
    }
    
    
    public IEnumerable<Deparment> GetAllDepartments()
    {
        return _conn.Query<Deparment>("SELECT * FROM Departments");
    }

    public void InsertDerpartment(string name)
    {
        _conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new { name = name });

    }
}