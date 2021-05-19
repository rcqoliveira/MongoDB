using RC.MongoDBApi.Domains;

namespace RC.MongoDBApi.Interface
{
    public interface IEmployeeRepository : IMongoRepository<Employee>
    {
       
    }
}