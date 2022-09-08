using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimProduct
    {
        public int ProductKey { get; set; }
        public string ProductAlternateKey { get; set; }
        public string ProductName { get; set; }
        public bool FinishedGoodFlag { get; set; }
        public byte[] ImageFile { get; set; }
        public string? ProductSubcategoryName { get; set; }
        public string? ProductCategoryName { get; set; }
        public string? WeightUnitMeasureCode { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? SizeRange { get; set; }
        public double? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string? ProductLine { get; set; }
        public string? Class { get; set; }
        public string? Style { get; set; }
        public string? ModelName { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
        public decimal? Price { get; set; }
    }
}
