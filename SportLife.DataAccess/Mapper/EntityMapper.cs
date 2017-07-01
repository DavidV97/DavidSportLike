using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Mapper
{
    public abstract class EntityMapper : ISqlStaments, IObjectMapper
    {
        protected string GetStringValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is string)
                return (string)val;

            return "";
        }

        protected int GetIntValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is int)
                return (int)dic[attName];

            return -1;
        }

        protected double GetDoubleValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is double)
                return (double)dic[attName];

            return -1;
        }

        protected DateTime GetDateValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is DateTime)
                return (DateTime)dic[attName];

            return DateTime.Now;
        }
        public abstract List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);
        public abstract BaseEntity BuildObject(Dictionary<string, object> row);
        public abstract SqlOperation GetCreateStatement(BaseEntity entity);
        public abstract SqlOperation GetCreateBillStatement(BaseEntity entity);
        public abstract SqlOperation GetRCreateStatement(BaseEntity entity);
        public abstract SqlOperation GetRetriveStatement(BaseEntity entity);
        public abstract SqlOperation GetRetriveAllStatement();
        public abstract SqlOperation GetUpdateStatement(BaseEntity entity);
        public abstract SqlOperation GetRUpdateStatement(BaseEntity entity);
        public abstract SqlOperation GetDeleteStatement(BaseEntity entity);
    }
}
