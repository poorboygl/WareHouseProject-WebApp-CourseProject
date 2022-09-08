using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DistrictRepository :BaseRepository
    {
        public DistrictRepository(IDbConnection connection) : base(connection)
        {

        }
        static District Fetch(IDataReader reader)
        {
            return new District
            {
                DistrictID = (string)reader["DistrictID"],
                ProvinceID = (string)reader["ProvinceID"],
                DistrictName = (string)reader["DistrictName"],              
            };
        }
        public List<District> GetDistricts(string provinceid)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetDictrict";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
               {
                    new Parameter{Name="ProvinceID ", Value = provinceid, DbType= DbType.String},
                };
                Add(command, parameters);
                List<District> list = new List<District>();
                using (IDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }

                }
                return list;
            }
        }
    }
}
