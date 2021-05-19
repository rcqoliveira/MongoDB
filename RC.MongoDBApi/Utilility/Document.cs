using MongoDB.Bson;
using RC.MongoDBApi.Interface;
using System;

namespace RC.MongoDBApi.Utilility
{

    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => DateTime.Now;
    }
}
