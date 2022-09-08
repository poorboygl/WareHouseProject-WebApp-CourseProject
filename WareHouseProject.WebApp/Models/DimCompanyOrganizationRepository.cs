using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimCompanyOrganizationRepository : BaseRepository
    {
        public DimCompanyOrganizationRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimCompanyOrganization Fetch(IDataReader reader)
        {
            return new DimCompanyOrganization
            {
                CompanyOrganizationKey = (int)reader["CompanyOrganizationKey"],
                Position = (string)reader["Position"],
                DepartmentGroupName = (string)reader["DepartmentGroupName"]
            };
        }
        public List<DimCompanyOrganization> GetCompanyOrganization()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetCompanyOrganization";
                command.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimCompanyOrganization> list = new List<DimCompanyOrganization>();
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
