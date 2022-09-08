using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class WardRepository : BaseRepository
    {
        public WardRepository(IDbConnection connection) : base(connection)
        {

        }
        static Ward Fetch(IDataReader reader)
        {
            return new Ward
            {
                WardID = (string)reader["WardID"],
                WardName = (string)reader["WardName"],
                DistrictID= (string)reader["DistrictID"],
            };
        }
        public List<Ward> GetWards(string dictrictid)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetWard";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
               {
                    new Parameter{Name="DictrictID ", Value = dictrictid, DbType= DbType.String},
                };
                Add(command, parameters);
                List<Ward> list = new List<Ward>();
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
