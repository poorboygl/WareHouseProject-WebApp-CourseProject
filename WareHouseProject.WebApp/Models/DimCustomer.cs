using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimCustomer
    {
        public int CustomerKey { get; set; }
        public string CustomerAlternateKey { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Suffix { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? StateProvinceName { get; set; }
        public string? CountryRegionName { get; set; }
        public byte? TotalChildren { get; set; }
        public byte? NumberChildrenAtHome { get; set; }
        public string? Education { get; set; }
        public string? Occupation { get; set; }
        public string? HouseOwnerFlag { get; set; }
        public byte? NumberCarsOwned { get; set; }
        public decimal? YearlyIncome { get; set; }
        public DateTime? DateFirstPurchase { get; set; }
        public string? CommuteDistance { get; set; }
    }

}
