using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class Parameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public DbType DbType { get; set; }
        public ParameterDirection Direction { get; set; }
    }
}

