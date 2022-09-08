using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimDepartmentGroupController : Controller
    {
        SiteProvider provider;
        public DimDepartmentGroupController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            return View(provider.DepartmentGroupRepository.GetDepartmentGroup());
        }
    }
}
