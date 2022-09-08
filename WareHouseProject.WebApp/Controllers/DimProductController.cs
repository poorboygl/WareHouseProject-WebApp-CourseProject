using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimProductController : Controller
    {
        SiteProvider provider;
        public DimProductController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCategories = provider.ProductCategoryRepository.GetProductCategories();
            return View(provider.ProductRepository.GetProducts());
        }
        public IActionResult ProductCategories(int id)
        {
            ViewBag.ProductCategories = provider.ProductCategoryRepository.GetProductCategories();
            return View("Index", provider.ProductRepository.GetProductByProductCategoryKey(id));
        }
        public IActionResult Detail(string id)
        {
            
            return View(provider.ProductRepository.GetProductByProductAlternateKey(id));
        }
    }
}
