using SportLike.DataAccess.Dao;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLike.DataAccess.Mapper
{
    public abstract class EntityMapper : ISqlStaments, IObjectMapper
    {
        protected string ClassName { get; set; }
        protected List<string> keyList;

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

        protected bool GetBooleanValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is DateTime)
                return (bool)dic[attName];

            return false;
        }
        public SqlOperation AddParameters(string procName, List<int> reqValues, List<object> values, BaseEntity entity)
        {
            var operation = new SqlOperation(procName);
            int x,i;
            for ( i = 0; i < reqValues.Count; i++)
            {
                x = 0;
                foreach (KeyValuePair<string, string> item in entity.ClassInfo)
                {
                    if (reqValues[i] == x)
                    {
                        switch (item.Value)
                        {
                            case "String":
                                operation.AddVarcharParam(ToSnakeCase(item.Key), (string)values[i]);
                                break;
                            case "Int32":
                                operation.AddIntParam(ToSnakeCase(item.Key), (int)values[i]);
                                break;
                            case "Double":
                                operation.AddDoubleParam(ToSnakeCase(item.Key), (double)values[i]);
                                break;
                            case "DateTime":
                                operation.AddDateParam(ToSnakeCase(item.Key), (DateTime)values[i]);
                                break;
                            case "Boolean":
                                operation.AddBooleanParam(ToSnakeCase(item.Key), (Boolean)values[i]);
                                break;
                        }
                    }
                    x++;
                }
            }

            return operation;
        }
        public abstract BaseEntity BuildObject(Dictionary<string, object> row);
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var entitys = new List<BaseEntity>();

            foreach (var dic in lstRows)
            {
                entitys.Add(BuildObject(dic));
            }
            return entitys;
        }
        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            return AddParameters("CRE_" + ClassName, GetReqValus("CRE_" + ClassName), entity.GetClassVal((BaseEntity)entity), entity);
        }
        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            return AddParameters("RCRE_" + ClassName, GetReqValus("RCRE_" + ClassName), entity.GetClassVal((BaseEntity)entity), entity);
        }
        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            return AddParameters("RET_" + ClassName, GetReqValus("RET_" + ClassName), entity.GetClassVal((BaseEntity)entity), entity);
        }
        public SqlOperation GetRetriveAllStatement()
        {
            return new SqlOperation("RET_" + ClassName + "S");
        }
        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            return AddParameters("UPD_" + ClassName, GetReqValus("UPD_" + ClassName), entity.GetClassVal((BaseEntity)entity), entity);
        }
        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            return AddParameters("DEL_" + ClassName, GetReqValus("DEL_" + ClassName), entity.GetClassVal((BaseEntity)entity), entity);
        }
        public abstract List<int> GetReqValus(string procName);
        public string ToSnakeCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToUpper();
        }
    }
}
