using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimProductCategoryRepository :BaseRepository
    {
        public DimProductCategoryRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimProductCategory Fetch(IDataReader reader)
        {
            return new DimProductCategory
            {
                ProductCategoryKey = (int)reader["ProductCategoryKey"],
                ProductCategoryAlternateKey = (int)reader["ProductCategoryAlternateKey"],
                ProductCategoryName = (string)reader["ProductCategoryName"],

            };
        }
        public List<DimProductCategory> GetProductCategories()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProductCategory";
                command.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimProductCategory> list = new List<DimProductCategory>();
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
