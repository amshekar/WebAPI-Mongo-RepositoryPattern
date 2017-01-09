using MongoDB.Driver;
using skillboardAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillboardAPI.Interfaces
{
    public interface IImageGalleryRepository : IRepository<ImageGallery>
    {
        //Task<IEnumerable<ImageGallery>> GetAllImages();
        //Task<ImageGallery> GetImage(string id);
        //Task AddImage(ImageGallery item);
        //Task<DeleteResult> RemoveImage(string id);

        //Task<UpdateResult> UpdateImage(string id, string description);

        //// demo interface - full document update
        //Task<ReplaceOneResult> UpdateImageDocument(string id, string body);

        //// should be used with high cautious, only in relation with demo setup
        //Task<DeleteResult> RemoveAllImages();
    }
}
