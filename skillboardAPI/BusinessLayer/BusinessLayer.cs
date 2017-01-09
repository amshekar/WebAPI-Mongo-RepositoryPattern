using skillboardAPI.Data;
using skillboardAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using skillboardAPI.Models;
using Microsoft.Extensions.Options;

namespace skillboardAPI.BusinessLayer
{
    public class BusinessLayers : IBusinessLayer
    {
        private readonly IImageGalleryRepository _imageRepository;
        private readonly SkillContext<ImageGallery> _context = null;

        public BusinessLayers(IOptions<Settings> settings)
        {
            _imageRepository = new ImageGalleryRepository(settings);
        }
        public BusinessLayers(IOptions<Settings> settings, IImageGalleryRepository imageRepository)
        {
            _imageRepository = imageRepository;
            _context = new SkillContext<ImageGallery>(settings);
        }

        public async Task AddImage(ImageGallery item)
        {
            await _imageRepository.AddImage(item);
        }

        public async Task<IEnumerable<ImageGallery>> GetAllImages()
        {
          return  await _imageRepository.GetAllImages();
        }

        public Task<ImageGallery> GetImage(string id)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> RemoveAllImages()
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> RemoveImage(string id)
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
