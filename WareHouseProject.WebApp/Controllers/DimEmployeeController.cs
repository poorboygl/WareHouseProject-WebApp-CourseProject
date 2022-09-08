using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimEmployeeController : Controller
    {
        SiteProvider provider;
        public DimEmployeeController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            ViewBag.DepartmentGroups = provider.DepartmentGroupRepository.GetDepartmentGroup();
            return View(provider.DimEmployeeRepository.GetEmployee());
        }
        public IActionResult DepartmentGroup(int id)
        {
            ViewBag.DepartmentGroups = provider.DepartmentGroupRepository.GetDepartmentGroup();
            return View("Index", provider.DimEmployeeRepository.GetEmployeeByDepartmentGroupKey(id));
        }
        public IActionResult Detail(string id)
        {
            return View(provider.DimEmployeeRepository.GetEmployeeByNationalIDAlternateKey(id));
        }

    }
}
