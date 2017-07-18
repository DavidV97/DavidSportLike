using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLike.DataAccess.Dao
{
    public class SqlDao
    {
        private static SqlDao _intance;
        private SqlDao() { }

        public static SqlDao GetInstance()
        {
            return _intance ?? (_intance = new SqlDao());
        }

        private const string ConnectionString = "database=SPORTLIKE_DB ; integrated security = true";

        public void ExecuteProcedure(SqlOperation sqlOperation)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation sqlOperation)
        {
            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var dict = new Dictionary<string, object>();
                        for (var lp = 0; lp < reader.FieldCount; lp++)
                        {
                            dict.Add(reader.GetName(lp), reader.GetValue(lp));
                        }
                        lstResult.Add(dict);
                    }
                }
            }

            return lstResult;
        }

        internal object ExecuteQueryProcedure(object operation)
        {
            throw new NotImplementedException();
        }

        internal void ExecuteProcedure(object operation)
        {
            throw new NotImplementedException();
        }
    }
}
