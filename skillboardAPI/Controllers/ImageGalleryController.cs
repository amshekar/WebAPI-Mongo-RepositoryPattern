using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skillboardAPI.Interfaces;
using skillboardAPI.Models;
using MongoDB.Bson;
using skillboardAPI.Extensions;
using skillboardAPI.BusinessLayer;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace skillboardAPI.Controllers
{
    [Route("api")]
    public class ImageGalleryController : Controller
    {
        private readonly IRepository<ImageGallery> _imageGalleryRepository;
        //public ImageGalleryController(IRepository<ImageGallery> imageGalleryRepository)
        //{
        //    _imageGalleryRepository = imageGalleryRepository;
        //}
        private readonly IBusinessLayer _businessLayer;
        public ImageGalleryController(IBusinessLayer businessLayer)
        {
            _businessLayer = businessLayer;
            
        }


        [HttpGet]
        [Route("imagegallery/{title}")]
        public Task<IActionResult> GetGalleryByName(string title)
        {
            return GetGalleryByNameInternal(title);


        }

        private async Task<IActionResult> GetGalleryByNameInternal(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }

            var result = await _businessLayer.GetImage(name);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return NotFound("No records Found");
        }


        [NoCache]
        [HttpGet]
        [Route("imagegallery")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _businessLayer.GetAllImages();
                if (result != null && result.Count() > 0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("No records Found");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        [HttpPost]
        [Route("imagegallery")]
        public async Task<IActionResult> AddGallery([FromBody]ImageGallery gallery)
        {
            try
            {

                ImageGallery galDoc = new ImageGallery()
                {
                    Id= ObjectId.GenerateNewId().ToString(),
                    Title = gallery.Title,
                    Comments = gallery.Comments,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    Description = gallery.Description,
                    Path = gallery.Path,
                    UserId=gallery.UserId

                };

                await _businessLayer.AddImage(galDoc);
                return Ok("Record added successfully");

            }
            catch (Exception ex)
            {

                return BadRequest();
            }



        }


    }
}
