using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimCustomerRepository:BaseRepository
    {
        public DimCustomerRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimCustomer Fetch(IDataReader reader)
        {
            return new DimCustomer
            {
                CustomerKey = (int)reader["CustomerKey"],
                CustomerAlternateKey = (string)reader["CustomerAlternateKey"],
                Title = reader["Title"] != DBNull.Value ? (string)reader["Title"] : null,
                FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : null,
                MiddleName = reader["MiddleName"] != DBNull.Value ? (string)reader["MiddleName"] : null,
                LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : null,
                Gender = reader["Gender"] != DBNull.Value ? (string)reader["Gender"] : null,
                BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : (DateTime?)null,
                MaritalStatus = reader["MaritalStatus"] != DBNull.Value ? (string)reader["MaritalStatus"] : null,
                Suffix = reader["Suffix"] != DBNull.Value ? (string)reader["Suffix"] : null,
                EmailAddress = reader["Username"] != DBNull.Value ? (string)reader["Username"] : null,
                Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : null,
                AddressLine1 = reader["AddressLine1"] != DBNull.Value ? (string)reader["AddressLine1"] : null,
                AddressLine2 = reader["AddressLine2"] != DBNull.Value ? (string)reader["AddressLine2"] : null,
                City = reader["City"] != DBNull.Value ? (string)reader["City"] : null,
                StateProvinceName = reader["StateProvinceName"] != DBNull.Value ? (string)reader["StateProvinceName"] : null,
                CountryRegionName = reader["CountryRegionName"] != DBNull.Value ? (string)reader["CountryRegionName"] : null,
                TotalChildren = reader["TotalChildren"] != DBNull.Value ? (byte)reader["TotalChildren"] : null,
                NumberChildrenAtHome = reader["NumberChildrenAtHome"] != DBNull.Value ? (byte)reader["NumberChildrenAtHome"] : null,
                Education = reader["Education"] != DBNull.Value ? (string)reader["Education"] : null,
                HouseOwnerFlag = reader["HouseOwnerFlag"] != DBNull.Value ? (string)reader["HouseOwnerFlag"] : null,
                NumberCarsOwned = reader["NumberCarsOwned"] != DBNull.Value ? (byte)reader["NumberCarsOwned"] : null,
                YearlyIncome = reader["YearlyIncome"] != DBNull.Value ? (decimal)reader["YearlyIncome"] : null,
                DateFirstPurchase = reader["DateFirstPurchase"] != DBNull.Value ? (DateTime)reader["DateFirstPurchase"] : (DateTime?)null,
                CommuteDistance = reader["CommuteDistance"] != DBNull.Value ? (string)reader["CommuteDistance"] : null,
            };
        }
        public List<DimCustomer> GetCustomer()
        {
            List<DimCustomer> list = new List<DimCustomer>();
           
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Getcustomer";
                    command.CommandType = CommandType.StoredProcedure;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                       

                        while (reader.Read())
                        {
                            list.Add(Fetch(reader));
                        }
                        
                    }
                }

           
            return list;
        }
        //Day la cach viet theo async
        public async Task< List<DimCustomer>> GetCustomerAsync()
        {
           

            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorksDW2014;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Getcustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        List<DimCustomer> list = new List<DimCustomer>();
                        while (await reader.ReadAsync())
                        {

                            list.Add(Fetch(reader));
                           
                        }
                        return list;
                    }
                   
                }
                connection.Close();
            }

           
        }
    }
}

