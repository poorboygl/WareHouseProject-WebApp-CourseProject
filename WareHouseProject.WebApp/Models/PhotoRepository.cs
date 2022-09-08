using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp.Models
{
    public class PhotoRepository :BaseRepository
    {
        public PhotoRepository(IDbConnection connection) : base(connection)
        {
        }
        static Photo Fetch(IDataReader reader)
        {
            return new Photo
            {
                Image = (byte[])reader["Image"],

            };
        }
        public int UpadateImage(byte[] photo)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UpdatePhoto";
                command.CommandType = CommandType.StoredProcedure;
                Parameter[] parameters =
               {
                    new Parameter{Name="Photo", Value = photo, DbType= DbType.Binary},
                 
                };
                Add(command, parameters);
                return command.ExecuteNonQuery();
            }
        }


    }
}
