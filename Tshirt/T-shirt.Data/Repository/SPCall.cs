using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Data.Data;
using T_shirt.Data.Repository.IRepository;

namespace T_shirt.Data.Repository
{
    public class SPCall : ISPCall
    {

        private readonly TshirtStoreDbContext database;
        private static string ConnectionString = "";

        public SPCall(TshirtStoreDbContext db)
        {

            database = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;

        }

        public void Dispose()
        {
           
            database.Dispose();

        }

        public void Execute(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                sqlConnection.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
              //  var result = SqlMapper.QueryMultiple(sqlConnection, procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
                return sqlConnection.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedureName, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(string procedureName, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
