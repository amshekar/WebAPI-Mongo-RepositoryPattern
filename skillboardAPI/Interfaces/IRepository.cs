using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillboardAPI.Interfaces
{
   public interface IRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAllImages();
        Task<T> GetImage(string id);
       // Task AddImage(T item);
        Task<T> AddImage(T entity);
        Task<T> RemoveImage(string id);

        Task<UpdateResult> UpdateImage(string id, string description);

        // demo interface - full document update
        Task<ReplaceOneResult> UpdateImageDocument(string id, string body);

        // should be used with high cautious, only in relation with demo setup
        Task<DeleteResult> RemoveAllImages();
    }
}
