using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillboardAPI.Interfaces
{
    public interface IRepository<T> where T : class
    {


        #region Select/Get/Query

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(string id);

        #endregion

        #region Insert

        Task<T> Insert(T entity);
        #endregion

        #region Update

        Task<UpdateResult> Update(string id, string description);

        // demo interface - full document update
        Task<ReplaceOneResult> UpdateDocument(string id, string body);

        #endregion

        #region Delete


        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="entity">Entity to be deleted</param>
        Task DeleteAsync(T entity);

        Task<T> Remove(string id);

        // should be used with high cautious, only in relation with demo setup
        Task<DeleteResult> RemoveAll();


        #endregion

        #region Aggregates

        #endregion




    }
}
