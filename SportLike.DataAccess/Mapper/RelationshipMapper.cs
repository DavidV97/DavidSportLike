using SportLife.Entities;
using SportLike.DataAccess.Dao;
using SportLike.DataAccess.Mapper;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Mapper
{
    public class RelationshipMapper : EntityMapper
    {
        public RelationshipMapper() { ClassName = "RELATIONSHIP"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Relationship relation = new Relationship();

            keyList = new List<string>(relation.ClassInfo.Keys);

            var IdRelationship = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdAdmin = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[2]));
            var Status = GetStringValue(row, ToSnakeCase(keyList[3]));
            var Type = GetStringValue(row, ToSnakeCase(keyList[4]));

            return new Relationship(relation.IdRelationship, relation.IdAdmin, relation.IdProfile,
                relation.Status, relation.Type);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4 });
            }
            else if (procName == "DEL_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else
            {
                return null;
            }
        }
    }
}
