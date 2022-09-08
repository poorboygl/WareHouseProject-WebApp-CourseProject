using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class Cart
    {
        public Guid CartKey { get; set; }
        public int ProductKey { get; set; }
        public string ProductName { get; set; }
        public string? ProductSubcategoryName { get; set; }
        public string? ProductAlternateKey { get; set; }
        public short Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CodeUser { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? AccountKey { get; set; }
        public decimal? Price { get; set; }

    }
}
