namespace ORM_Dapper;
//'namespace' is used to group realted code together.
//'ORM-Dapper' is the name of the namespace for all classes related in ORM and Dapper.

public interface IDepartmentRepository
//'interface' defines a contract or list of methods that a class must implement.
//'IDepartmentRepository' is the name if the interface for department data access.
{
    public IEnumerable<Deparment> GetAllDepartments();
    //'IEnumerable<Deparment>' means this method returns a list or collection
    //Explanation: The angle brackets '<>' specify the type of items in the collection in here 'Deparment'
    // This method, GetAllDepartments(); will return all departments as collection you can go though one by one.
}