using RC.MongoDBApi.Domains;
using RC.MongoDBApi.Interface;

namespace RC.MongoDBApi.Repository
{
    public class EmployeeRepository : MongoRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IMongoDbSettings settings) : base(settings)
        {
        }
    }
}