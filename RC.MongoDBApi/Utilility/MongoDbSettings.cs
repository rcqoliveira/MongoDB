using RC.MongoDBApi.Interface;

namespace RC.MongoDBApi.Utilility
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}