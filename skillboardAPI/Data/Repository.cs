using skillboardAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using skillboardAPI.Models;
using skillboardAPI.Data;
using MongoDB.Bson;

namespace skillboardAPI.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        


        private readonly SkillContext<T> _context;
        IOptions<Settings> settings;

       
        // IOptions<Settings> settings;
        //public Repository()
        //{
        //    _context = new SkillContext<T>(settings);
        //}
        public Repository(IOptions<Settings> settings)
        {
            _context = new SkillContext<T>(settings);

        }



        public async Task<T> AddImage(T entity)
        {
            await _context.Collection.InsertOneAsync(entity);
            return entity;
        }



        public async Task<IEnumerable<T>> GetAllImages()
        {

            return await _context.Collection.Find(_ => true).ToListAsync();


        }

        public async Task<T> GetImage(string name)
        {
            var filter = Builders<T>.Filter.Eq("Title", name);
            return await _context.Collection.Find(filter).FirstOrDefaultAsync();

        }


        public async Task<DeleteResult> RemoveAllImages()
        {
            return await _context.ImageGallery.DeleteManyAsync(new BsonDocument());
        }

        public Task<T> RemoveImage(string id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResult> UpdateImage(string id, string description)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceOneResult> UpdateImageDocument(string id, string body)
        {
            throw new NotImplementedException();
        }

    }
}
