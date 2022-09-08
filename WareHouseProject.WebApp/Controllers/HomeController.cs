using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class HomeController : Controller
    {
        SiteProvider provider;
        public HomeController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Index(int id =1)
        {
            ViewBag.ProductCategories = provider.ProductCategoryRepository.GetProductCategories();
            int size = 12;
            int total;
            List<DimProduct> list = provider.ProductRepository.GetProducts((id - 1) * size, size, out total);
            //ViewBag.n = (total - 1) / size + 1;
            ViewBag.total = total;
            return View(list);
        }
        [Route("/home/category/{id}/{p?}")]
        public IActionResult Category(int id, int p=1)
        {
            ViewBag.ProductCategories = provider.ProductCategoryRepository.GetProductCategories();
            int size = 12;
            int total;
            List<DimProduct> list = provider.ProductRepository.GetProductByProductCategoryKey(id,(p-1)*size,size, out total);
            ViewBag.total = total;
            return View(list);
        }

        public IActionResult Search(string q, int id = 1)
        {
            ViewBag.ProductCategories = provider.ProductCategoryRepository.GetProductCategories();
            int size = 12;
            int total;
            List<DimProduct> list = provider.ProductRepository.Search(q, (id - 1) * size, size, out total);
            ViewBag.total = total;
            return View(list);
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
