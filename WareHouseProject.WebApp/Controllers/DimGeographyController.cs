using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimGeographyController : Controller
    {
        SiteProvider provider;
        public DimGeographyController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            return View(provider.GeographyRepository.GetGeography());
        }
    }
}
