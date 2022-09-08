using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace WareHouseProject.WebApp.Models
{
    public class CartRepository :BaseRepository
    {
        public CartRepository(IDbConnection connection) : base(connection)
        {

        }
         static Cart Fetch(IDataReader reader)
        {
            return new Cart
            {
                CartKey = (Guid)reader["CartKey"],
                ProductKey = (int)reader["ProductKey"],
                Quantity = (short)reader["Quantity"],              
                AccountKey = reader["AccountKey"] != DBNull.Value ? (int)reader["AccountKey"] : null,
            };
        }
        static Cart FetchAll(IDataReader reader)
        {
            Cart obj = Fetch(reader);
            obj.CodeUser = reader["CodeUser"] != DBNull.Value ? (string)reader["CodeUser"] : null;
            obj.Firstname = (string)reader["Firstname"];
            obj.LastName = (string)reader["LastName"];
            obj.MiddleName = reader["MiddleName"] != DBNull.Value ? (string)reader["MiddleName"] : null;
            obj.Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : null;
            obj.Price = reader["Price"] != DBNull.Value ? (decimal)reader["Price"] : 0;
            obj.ProductName = reader["ProductName"] != DBNull.Value ? (string)reader["ProductName"] : null;
            obj.ProductAlternateKey= reader["ProductAlternateKey"] != DBNull.Value ? (string)reader["ProductAlternateKey"] : null;
            obj.CreatedDate = reader["CreatedDate"] != DBNull.Value ? (DateTime)reader["CreatedDate"] : (DateTime?)null;
            obj.Address = reader["Address"] != DBNull.Value ? (string)reader["Address"] : null;
            obj.ProductSubcategoryName =  reader["ProductSubcategoryName"] != DBNull.Value ? (string)reader["ProductSubcategoryName"] : null;
            return obj;
        }
        public int Delete(Guid cartkey, int productkey)
        {

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DeleteItemInCart";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="CartKey", Value = cartkey, DbType= DbType.Guid},
                     new Parameter{Name="ProductKey", Value =productkey, DbType= DbType.Int32},
                };
                Add(command, parameters);
                return command.ExecuteNonQuery();
            }
        }

        public int Update(Cart obj)
        {

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UpdateCart";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="CartKey", Value = obj.CartKey, DbType= DbType.Guid},
                    new Parameter{Name="Quantity", Value =obj.Quantity, DbType= DbType.Int16},
                     new Parameter{Name="ProductKey", Value =obj.ProductKey, DbType= DbType.Int32},
                };
                Add(command, parameters);              
                return command.ExecuteNonQuery();
            }
        }
        public List<Cart> GetCarts(Guid key, int? accountKey)
        {

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "GetCarts";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="CartKey", Value = key, DbType= DbType.Guid},
                    new Parameter{Name="AccountKey", Value =accountKey, DbType= DbType.Int32},
                };
                Add(command, parameters);
                List<Cart> list = new List<Cart>();
                using (IDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(FetchAll(reader));
                    }
                }
                return list;
            }
        }
        public List<Cart> AddCart(Cart obj)
        {

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "AddCart";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="CartKey", Value = obj.CartKey, DbType= DbType.Guid},
                    new Parameter{Name="ProductKey", Value = obj.ProductKey, DbType= DbType.Int32},
                    new Parameter{Name="Quantity", Value = obj.Quantity, DbType= DbType.Int32},
                    new Parameter{Name="AccountKey", Value =obj.AccountKey, DbType= DbType.Int32},
                };
                Add(command, parameters);
                List<Cart> list = new List<Cart>();
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
