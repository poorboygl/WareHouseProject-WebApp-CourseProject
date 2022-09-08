using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;


namespace WareHouseProject.WebApp.Controllers
{
    public class PhotoUploadController : Controller
    {
        SiteProvider provider;
        public PhotoUploadController(SiteProvider provider)
        {
            this.provider = provider;
        }

        public IActionResult Ajax()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajax(IFormFile f)
        {
            string path = Directory.GetCurrentDirectory();
            using (MemoryStream ms = new MemoryStream())
            {
                f.CopyTo(ms);
                byte[] bytes = ms.ToArray();
                provider.Photo.UpadateImage(bytes);
                return Json( new { Img = bytes });
            }
        }
    }
}
