using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimProductCategoryController : Controller
    {
        SiteProvider provider;
        public DimProductCategoryController(SiteProvider provider)
        {
            this.provider = provider;
        }

        public IActionResult Index()
        {
            return View(provider.ProductCategoryRepository.GetProductCategories());
        }
    }
}
