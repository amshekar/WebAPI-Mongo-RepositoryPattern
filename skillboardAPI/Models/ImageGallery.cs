using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillboardAPI.Models
{

    [BsonIgnoreExtraElements]
    public class ImageGallery
    {
        [BsonElement("imagegalleryid")]
        [BsonId]
        public string Id { get; set; }
        [BsonElement("imagetitle")]
        public string Title { get; set; }
        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;
        [BsonElement("path")]
        public string Path { get; set; }
        [BsonElement("comments")]
        public string Comments { get; set; } = string.Empty;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [BsonElement("userid")]
        public string UserId { get; set; }
    }
}
