using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class Account
    {
        public int AccountKey { get; set; }
        public string Username { get; set; }
        public string CodeUser { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public bool CustomerFlag { get; set; }
        public Guid? CartKey { get; set; }

        //---------------------
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string ProvinceID { get; set; }
        public string DistrictID { get; set; }
        public string WardID { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
    }
}
