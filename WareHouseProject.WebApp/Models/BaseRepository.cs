using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace WareHouseProject.WebApp.Models
{
    public abstract class BaseRepository
    {
        protected IConfiguration configuration;

        public BaseRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IDbConnection connection;
        public BaseRepository(IDbConnection connection)
        {
            this.connection = connection;
        }
        public void Add(IDbCommand command, Parameter parameter)
        {
            IDataParameter dataParameter = command.CreateParameter();
            dataParameter.ParameterName = parameter.Name;
            dataParameter.Value = parameter.Value;
            //thieu
            dataParameter.DbType = parameter.DbType;
            //SAI CHO NAY
            dataParameter.Direction = parameter.Direction;
            command.Parameters.Add(dataParameter);
        }
        public void Add(IDbCommand command, Parameter[] parameters)
        {
            foreach (Parameter item in parameters)
            {
                Add(command, item);
            }
        }
        public int Save(string sql, Parameter parameter)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("AdventureWorksDW2014")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    Add(command, parameter);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        public int Save(string sql, Parameter[] parameters)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("AdventureWorksDW2014")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    Add(command, parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

    }
}
