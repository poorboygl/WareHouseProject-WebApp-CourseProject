using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimProductSubcategoryRepository :BaseRepository
    {
        public DimProductSubcategoryRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimProductSubcategory Fetch(IDataReader reader)
        {
            return new DimProductSubcategory
            {
               
                ProductSubCategoryKey = (int)reader["ProductSubCategoryKey"],
                ProductSubCategoryAlternateKey = (int)reader["ProductSubCategoryAlternateKey"],
                ProductSubCategoryName = (string)reader["ProductSubcategoryName"],              
                ProductCategory = (string)reader["CategoryName"]
            };
        }
        public List<DimProductSubcategory> GetProductSubcategory()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProductSubCategory";
                command.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimProductSubcategory> list = new List<DimProductSubcategory>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }
        }
    }
}
