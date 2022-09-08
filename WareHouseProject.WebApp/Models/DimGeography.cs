using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimGeography
    {
        public int GeographyKey { get; set; }
        public string? City { get; set; }
        public string? StateProvinceCode { get; set; }
        public string? StateProvinceName { get; set; }
        public string? CountryRegionCode { get; set; }
        public string? CountryRegionName { get; set; }
        public string? PostalCode { get; set; }
        public string? IpAddressLocator { get; set; }
    }
}
