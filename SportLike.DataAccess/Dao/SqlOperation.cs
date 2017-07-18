using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLike.DataAccess.Dao
{
    public class SqlOperation
    {

        public string ProcedureName { get; set; }
        public List<SqlParameter> Parameters { get; set; }

        public SqlOperation(string procedureName)
        {
            ProcedureName = procedureName;
            Parameters = new List<SqlParameter>();
        }

        public void AddVarcharParam(string paramName, string paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.VarChar)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddIntParam(string paramName, int paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Int)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddDoubleParam(string paramName, double paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Decimal)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        internal void AddDateParam(string paramName, DateTime paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Date)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddBooleanParam(string paramName, Boolean paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Bit)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }
    }
}
