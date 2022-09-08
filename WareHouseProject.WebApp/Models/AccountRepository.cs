using System;
using System.Data;

namespace WareHouseProject.WebApp.Models
{
    public class AccountRepository :BaseRepository
    {
        public AccountRepository(IDbConnection connection) : base(connection)
        {

        }
        static Account Fetch(IDataReader reader)
        {
            return new Account
            {
                AccountKey = (int)reader["AccountKey"],
                LastName = (string)reader["LastName"],
                CodeUser=(string)reader["Code"],
                Position = (bool)reader["CustomerFlag"]==true ? "Customer":(string)reader["Position"],
                Username = (string)reader["Username"],
                CustomerFlag=(bool)reader["CustomerFlag"],
                CartKey = reader["CartKey"] != DBNull.Value ? (Guid)reader["CartKey"] : null,
            };
        }
        public Account SignIn(SignInModel obj)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SignIN";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {
                    new Parameter{Name="Usr", Value = obj.Usr, DbType= DbType.String},
                    new Parameter{Name="Pwd", Value = Helper.Sha(obj.Pwd), DbType= DbType.Binary}
                };
                Add(command, parameters);
                using (IDataReader reader = command.ExecuteReader())
                {                  
                    if (reader.Read())
                    {
                        return Fetch(reader);
                    }
                    return null;
                }
            }
        }
        public int Register(Account obj)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "CreateAccount";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
                {

                    new Parameter{Name="@CustomerAlternateKey", Value = Helper.RandomString(15), DbType= DbType.String},
                    new Parameter{Name="@FirstName", Value = obj.FirstName, DbType= DbType.String},
                    new Parameter{Name="@LastName", Value = obj.LastName, DbType= DbType.String},
                    new Parameter{Name="@MiddleName", Value = obj.MiddleName, DbType= DbType.String},
                    new Parameter{Name="@Phone", Value = obj.Phone, DbType= DbType.String},
                    new Parameter{Name="@Address", Value = obj.Address, DbType= DbType.String},
                    new Parameter{Name="@wardID", Value = obj.WardID, DbType= DbType.String},
                    new Parameter{Name="@Image", Value = obj.Image, DbType= DbType.Binary},
                    new Parameter{Name="@Username", Value = obj.Username, DbType= DbType.String},
                     new Parameter{Name="@Password", Value =Helper.Sha(obj.Password), DbType= DbType.Binary},
                };
                Add(command, parameters);
                return command.ExecuteNonQuery();
            }
        }
    }
}
