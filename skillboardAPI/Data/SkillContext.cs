using Microsoft.Extensions.Options;
using MongoDB.Driver;
using skillboardAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillboardAPI.Data
{
    public class SkillContext<T> where T : class
    {
        private readonly IMongoDatabase _database = null;

        public SkillContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);

            }

        }


        public virtual IMongoCollection<T> Collection
        {
            get
            {

                return _database.GetCollection<T>(typeof(T).Name);
            }
        }

        public IMongoCollection<ImageGallery> ImageGallery


        {
            get
            {
                return _database.GetCollection<ImageGallery>("ImageGallery");
            }
        }
    }
}
