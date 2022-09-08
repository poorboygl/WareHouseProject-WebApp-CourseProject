using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimEmployee
    {
        public int EmployeeKey { get; set; }
        public string? EmployeeNationalIDAlternateKey { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Gender { get; set; }
        public string? Position { get; set; }
        public string? DepartmentGroupName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }

        public bool SalariedFlag { get; set; }
        public bool CurrentFlag { get; set; }
        public bool SalesPersonFlag { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }
        public string? MaritalStatus { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone { get; set; }
        public byte[]? EmployeePhoto { get; set; }

    }
}
