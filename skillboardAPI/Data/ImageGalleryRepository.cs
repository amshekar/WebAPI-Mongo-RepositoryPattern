using skillboardAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using skillboardAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;


namespace skillboardAPI.Data
{
    public class ImageGalleryRepository : Repository<ImageGallery>, IImageGalleryRepository
    {
        public ImageGalleryRepository(IOptions<Settings> settings) : base(settings)
        {
        }


    }
}
