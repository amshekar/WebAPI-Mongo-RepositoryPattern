using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillboardAPI.Models
{
    public class ImageGallery
    {
        [BsonId]
        public string Id { get; set; }
        public string Title { get; set; }       
        public string Description { get; set; } = string.Empty;
        public string Path { get; set; }
        public string Comments { get; set; } = string.Empty;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string UserId { get; set; } 
    }
}
