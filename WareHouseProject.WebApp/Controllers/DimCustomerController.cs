using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimCustomerController : Controller
    {
        SiteProvider provider;
        public DimCustomerController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public async Task<IActionResult>  Index()
        {
            List<DimCustomer> list = await provider.CustomerRepository.GetCustomerAsync();
            return View(list) ;
        }
    }
}
