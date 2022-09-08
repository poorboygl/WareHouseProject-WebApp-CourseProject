using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimEmployeeRepository :BaseRepository
    {
        public DimEmployeeRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimEmployee Fetch(IDataReader reader)
        {
            return new DimEmployee
            {
                EmployeeKey = (int)reader["EmployeeKey"],
                EmployeeNationalIDAlternateKey = reader["EmployeeNationalIDAlternateKey"] != DBNull.Value ? (string)reader["EmployeeNationalIDAlternateKey"] : null,
                FirstName = (string)reader["FirstName"],
                MiddleName = reader["MiddleName"] != DBNull.Value ? (string)reader["MiddleName"] : null,
                LastName = (string)reader["LastName"],
                Gender = reader["Gender"] != DBNull.Value ? (string)reader["Gender"] : null,
                Position = reader["Position"] != DBNull.Value ? (string)reader["Position"] : null,
                DepartmentGroupName = reader["DepartmentGroupName"] != DBNull.Value ? (string)reader["DepartmentGroupName"] : null,
                HireDate = reader["HireDate"] != DBNull.Value ? (DateTime)reader["HireDate"] : (DateTime?)null,
                StartDate = reader["StartDate"] != DBNull.Value ? (DateTime)reader["StartDate"] : (DateTime?)null,
                EndDate = reader["EndDate"] != DBNull.Value ? (DateTime)reader["EndDate"] : (DateTime?)null,
                Status = reader["Status"] != DBNull.Value ? (string)reader["Status"] : null,
                SalariedFlag = (bool)reader["SalariedFlag"],
                SalesPersonFlag = (bool)reader["SalesPersonFlag"],
                Birthdate = reader["Birthdate"] != DBNull.Value ? ((DateTime)reader["Birthdate"]) : (DateTime?)null,
                EmailAddress = reader["Username"] != DBNull.Value ? (string)reader["Username"] : null,
                Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : null,
                MaritalStatus = reader["MaritalStatus"] != DBNull.Value ? (string)reader["MaritalStatus"] : null,
                EmergencyContactName = reader["EmergencyContactName"] != DBNull.Value ? (string)reader["EmergencyContactName"] : null,
                EmergencyContactPhone = reader["EmergencyContactPhone"] != DBNull.Value ? (string)reader["EmergencyContactPhone"] : null,
                EmployeePhoto = reader["EmployeePhoto"] != DBNull.Value ? (byte[])reader["EmployeePhoto"] : null,
            };
        }
        public DimEmployee GetEmployeeByNationalIDAlternateKey(string key)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetEmployeeByNationalIDAlternateKey";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="EmployeeNationalIDAlternateKey",Value = key, DbType= DbType.String}
                };
                Add(command, parameters);
                using (IDataReader reader = command.ExecuteReader())
                {
                    DimEmployee employee = new DimEmployee();
                    while (reader.Read())
                    {
                        employee = Fetch(reader);
                    }
                    return employee;
                }
                
            }
        }
        public List<DimEmployee> GetEmployeeByDepartmentGroupKey(int key)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetEmployeeByDepartmentGroupKey";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="DepartmentGroupKey", Value = key, DbType= DbType.Int32}
                };
                Add(command, parameters);
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimEmployee> list = new List<DimEmployee>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }
        }
        public  List<DimEmployee> GetEmployee()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetEmployee";
                command.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimEmployee> list = new List<DimEmployee>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return  list;
                }
            }
        }
    }
}
