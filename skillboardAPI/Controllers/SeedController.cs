using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skillboardAPI.Interfaces;
using skillboardAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace skillboardAPI.Controllers
{
    [Route("api")]
    public class SeedController : Controller
    {
        private readonly IImageGalleryRepository _imageGalleryRepository;
        public SeedController(IImageGalleryRepository imageGalleryRepository)
        {
            _imageGalleryRepository = imageGalleryRepository;
        }
        // Call an initialization - api/seed/init
        [HttpGet]
        [Route("seed/{setting}")]
        public string Get(string setting)
        {
            if (setting == "init")
            {

                try
                {
                    _imageGalleryRepository.RemoveAllImages();
                    _imageGalleryRepository.AddImage(new ImageGallery()
                    {
                        Id = "1",
                        Description = "If you're a service business, freelancer or entrepreneur, the Skillvo Digital Marketing Platform is designed for you to showcase your work and connect you with clients seeking your skills and services.",
                        Comments = "Automated search engine optimization",
                        Path = "~/Images/skillVo1.jpg",
                        Title = "Skill Vo1",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        UserId = "1"
                    });
                    _imageGalleryRepository.AddImage(new ImageGallery()
                    {
                        Id = "2",
                        Description = "If you're a service business, freelancer or entrepreneur, the Skillvo Digital Marketing Platform is designed for you to showcase your work and connect you with clients seeking your skills and services.",
                        Comments = "Automated search engine optimization",
                        Path = "~/Images/skillVo1.jpg",
                        Title = "Skill Vo2",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        UserId = "1"
                    });
                    _imageGalleryRepository.AddImage(new ImageGallery()
                    {
                        Id = "3",
                        Description = "If you're a service business, freelancer or entrepreneur, the Skillvo Digital Marketing Platform is designed for you to showcase your work and connect you with clients seeking your skills and services.",
                        Comments = "Automated search engine optimization",
                        Path = "~/Images/skillVo1.jpg",
                        Title = "Skill Vo3",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        UserId = "1"
                    });

                    _imageGalleryRepository.AddImage(new ImageGallery()
                    {
                        Id = "4",
                        Description = "If you're a service business, freelancer or entrepreneur, the Skillvo Digital Marketing Platform is designed for you to showcase your work and connect you with clients seeking your skills and services.",
                        Comments = "Automated search engine optimization",
                        Path = "~/Images/skillVo1.jpg",
                        Title = "Skill Vo4",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        UserId = "2"
                    });
                    return "Seed Done";

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return "unknownRequest";
        }
    }
}
