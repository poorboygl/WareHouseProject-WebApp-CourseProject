using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimGeographyRepository:BaseRepository
    {
        public DimGeographyRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimGeography Fetch(IDataReader reader)
        {
            return new DimGeography
            {
                GeographyKey = (int)reader["GeographyKey"],
                City = reader["City"]!=DBNull.Value?(string)reader["City"]:null,
                StateProvinceCode = reader["StateProvinceCode"] != DBNull.Value ? (string)reader["StateProvinceCode"] : null,
                StateProvinceName = reader["StateProvinceName"] != DBNull.Value ? (string)reader["StateProvinceName"] : null,
                CountryRegionCode = reader["CountryRegionCode"] != DBNull.Value ? (string)reader["CountryRegionCode"] : null,
                CountryRegionName = reader["CountryRegionName"] != DBNull.Value ? (string)reader["CountryRegionName"] : null,
                PostalCode = reader["PostalCode"] != DBNull.Value ? (string)reader["PostalCode"] : null,
                IpAddressLocator = reader["IpAddressLocator"] != DBNull.Value ? (string)reader["IpAddressLocator"] : null,
            };
        }
        public List<DimGeography> GetGeography()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetGeography";
                command.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimGeography> list = new List<DimGeography>();
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
