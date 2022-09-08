using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public abstract class BaseProvider :IDisposable
    {
        IConfiguration configuraton;
        public BaseProvider (IConfiguration configuration)
        {
            this.configuraton = configuration;
        }
        IDbConnection connection;
        protected IDbConnection Connection
        {
            get
            {
                if (connection is null)
                {
                    connection = new SqlConnection(configuraton.GetConnectionString("AdventureWorksDW2014"));
                    connection.Open();
                    Console.WriteLine("Mở Kết Nối");
                }
                return connection;
            }
        }
        public void Dispose()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                Console.WriteLine("Đã đóng kết nối");
            }
        }
    }
}
