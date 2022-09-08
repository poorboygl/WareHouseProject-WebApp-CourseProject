using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class DimProductRepository :BaseRepository
    {
        public DimProductRepository(IDbConnection connection) : base(connection)
        {

        }
        static DimProduct Fetch(IDataReader reader)
        {
            return new DimProduct
            {
                ProductKey = (int)reader["ProductKey"],
                ProductAlternateKey = (string)reader["ProductAlternateKey"],
                ProductName = (string)reader["ProductName"],
                FinishedGoodFlag = (bool)reader["FinishedGoodsFlag"],
                ImageFile = (byte[])reader["LargePhoto"],
                ProductSubcategoryName = reader["ProductSubcategoryName"] != DBNull.Value ? (string)reader["ProductSubcategoryName"] : null,
                ProductCategoryName = reader["ProductCategoryName"]!= DBNull.Value?(string)reader["ProductCategoryName"]:null,
                WeightUnitMeasureCode= reader["WeightUnitMeasureCode"]!=DBNull.Value?(string)reader["WeightUnitMeasureCode"]:null,
                Color= reader["Color"]!=DBNull.Value?(string)reader["Color"]:null,
                Size = reader["Size"]!=DBNull.Value?(string)reader["Size"]:null,
                SizeRange = reader["SizeRange"]!=DBNull.Value?(string)reader["SizeRange"]:null,
                Weight = reader["Weight"]!=DBNull.Value?(double)reader["Weight"]:null,
                DaysToManufacture = (int)reader["DaysToManufacture"],
                ProductLine = reader["ProductLine"]!=DBNull.Value?(string)reader["ProductLine"]:null,
                Class = reader["Class"]!=DBNull.Value?(string)reader["Class"]:null,
                Style = reader["Style"]!=DBNull.Value?(string)reader["Style"]:null,
                ModelName= reader["ModelName"]!=DBNull.Value?(string)reader["ModelName"]:null,
                Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : null,
                StartDate = reader["StartDate"]!=DBNull.Value?(DateTime)reader["StartDate"]: (DateTime?)null,
                EndDate = reader["EndDate"]!=DBNull.Value?(DateTime)reader["EndDate"]: (DateTime?)null,
                Status = reader["Status"]!=DBNull.Value?(string)reader["Status"]:null,
                Price = reader["Price"] != DBNull.Value ? (Decimal)reader["Price"] : null,
            };
        }
        public List<DimProduct> Search(string q, int index, int size, out int total)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SearchProduct";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="q", Value = '%'+q+'%', DbType= DbType.String},
                    new Parameter{Name="Index", Value = index, DbType= DbType.Int32},
                    new Parameter{Name="Size", Value = size, DbType= DbType.Int32},
                    new Parameter{Name="Total", DbType= DbType.Int32, Direction = ParameterDirection.Output},
                };
                Add(command, parameters);
                List<DimProduct> list = new List<DimProduct>();
                using (IDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }

                }
                IDataParameter parameter = (IDataParameter)command.Parameters["Total"];
                total = (int)parameter.Value;
                return list;
            }
        }
        public DimProduct GetProductByProductAlternateKey(string key)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProductByProductAlternateKey";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="ProductAlternateKey", Value = key, DbType= DbType.String}
                };
                Add(command, parameters);
                using (IDataReader reader = command.ExecuteReader())
                {
                    DimProduct product = new DimProduct();
                    while (reader.Read())
                    {
                        product=Fetch(reader);
                    }
                    return product;
                }
            }
        }
        public List<DimProduct> GetProductByProductCategoryKey(int key, int index, int size, out int total)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProductByProductCategoryKeyHavePagination";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="ProductCategoryKey", Value = key, DbType= DbType.Int32},
                    new Parameter{Name="Index", Value = index, DbType= DbType.Int32},
                    new Parameter{Name="Size", Value = size, DbType= DbType.Int32},
                    new Parameter{Name="Total", DbType= DbType.Int32, Direction = ParameterDirection.Output},
                };
                Add(command, parameters);
                List<DimProduct> list = new List<DimProduct>();
                using (IDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }

                }
                IDataParameter parameter = (IDataParameter)command.Parameters["Total"];
                total = (int)parameter.Value;
                return list;
            }
        }
        public List<DimProduct> GetProductByProductCategoryKey(int key)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProductByProductCategoryKey";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="ProductCategoryKey", Value = key, DbType= DbType.Int32}
                };
                Add(command, parameters);
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimProduct> list = new List<DimProduct>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }
        }
        public List<DimProduct> GetProducts(int index, int size, out int total)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProductsPagination";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
               {
                    new Parameter{Name="Index", Value = index, DbType= DbType.Int32},
                    new Parameter{Name="Size", Value = size, DbType= DbType.Int32},
                    new Parameter{Name="Total", DbType= DbType.Int32, Direction= ParameterDirection.Output},
                };
                Add(command, parameters);
                List<DimProduct> list = new List<DimProduct>();
                using (IDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }

                }
                IDataParameter parameter = (IDataParameter)command.Parameters["Total"];
                total = (int)parameter.Value;
                return list;
            }
        }
        public List<DimProduct> GetProducts()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetProduct";
                command.CommandType = CommandType.StoredProcedure;
               
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<DimProduct> list = new List<DimProduct>();
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
