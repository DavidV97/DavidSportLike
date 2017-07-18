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
    public class LikeMapper : EntityMapper
    {
        public LikeMapper() { ClassName = "LIKE"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Like like = new Like();

            keyList = new List<string>(like.ClassInfo.Keys);

            var IdLike = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdPublication = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdProfile = GetIntValue(row, ToSnakeCase(keyList[2]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[3]));

            return new Like(like.IdLike, like.IdPublication, like.IdProfile, like.Active);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3 });
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
