using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class DimCompanyOrganizationController : Controller
    {
        SiteProvider provider;
        public DimCompanyOrganizationController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            return View(provider.CompanyOrganizationRepository.GetCompanyOrganization());
        }
    }
}
