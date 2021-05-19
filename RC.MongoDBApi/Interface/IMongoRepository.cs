using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RC.MongoDBApi.Interface
{
    public interface IMongoRepository<T> where T : IDocument
    {
        void InsertOne(T document);
        Task DeleteByIdAsync(string id);
        Task InsertOneAsync(T document);
        Task<T> FindByIdAsync(string id);
        Task ReplaceOneAsync(T document);
        Task InsertManyAsync(ICollection<T> documents);
        Task DeleteAsync(Expression<Func<T, bool>> filterExpression);
        Task<T> FindOneAsync(Expression<Func<T, bool>> filterExpression);
        IEnumerable<T> FilterBy(Expression<Func<T, bool>> filterExpression);
    }
}