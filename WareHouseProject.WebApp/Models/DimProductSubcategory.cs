using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimProductSubcategory
    {
        public int ProductSubCategoryKey { get; set; }
        public int ProductSubCategoryAlternateKey { get; set; }
        public string ProductSubCategoryName { get; set; }
        public string ProductCategory { get; set; }
    }
}
