using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage ="Error Username")]
        public string Usr { get; set; }
        [Required(ErrorMessage = "Error Password")]
        public string Pwd { get; set; }
        public bool Rem { get; set; }
    }
}
