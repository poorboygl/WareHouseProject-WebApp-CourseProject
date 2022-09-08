using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class ProvinceRepository : BaseRepository
    {
        public ProvinceRepository(IDbConnection connection) : base(connection)
        {

        }
        static Province Fetch(IDataReader reader)
        {
            return new Province
            {
                ProvinceID = (string)reader["ProvinceID"],
                ProvinceName = (string)reader["ProvinceName"],
            };
        }
        public List<Province> GetProvinces()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProvince";
                command.CommandType = CommandType.StoredProcedure;
                List<Province> list = new List<Province>();
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
