using RC.MongoDBApi.Utilility;

namespace RC.MongoDBApi.Domains
{
    [BsonCollection("employee")]
    public class Employee : Document
    {
        public string EmployeeName { get; set; }

        public Employee(string employeeName)
        {
            this.EmployeeName = employeeName;

        }
    }
}