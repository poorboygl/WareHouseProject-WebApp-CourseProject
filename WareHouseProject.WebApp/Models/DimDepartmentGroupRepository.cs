using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimDepartmentGroupRepository :BaseRepository
    {
        public DimDepartmentGroupRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimDepartmentGroup Fetch(IDataReader reader)
        {
            return new DimDepartmentGroup
            {
                DepartmentGroupKey = (int)reader["DepartmentGroupKey"],
                DepartmentGroupName = (string)reader["DepartmentGroupName"],
                

            };
        }
        public List<DimDepartmentGroup> GetDepartmentGroup()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetDepartmentGroup";
                command.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimDepartmentGroup> list = new List<DimDepartmentGroup>();
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
