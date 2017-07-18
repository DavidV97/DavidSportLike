using SportLike.DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportLike.DataAccess.Dao;
using SportLike.Entities;
using SportLife.Entities;

namespace SportLife.DataAccess.Mapper
{
    public class ResultMapper : EntityMapper
    {
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Result result = new Result();

            keyList = new List<string>(result.ClassInfo.Keys);

            var IdResult = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[2]));
            var Position = GetIntValue(row, ToSnakeCase(keyList[3]));
            var Points = GetIntValue(row, ToSnakeCase(keyList[4]));
            var Status = GetStringValue(row, ToSnakeCase(keyList[5]));
            var Time = GetStringValue(row, ToSnakeCase(keyList[6]));
            var EventQualification = GetIntValue(row, ToSnakeCase(keyList[7]));

            return new Result(result.IdResult, result.IdProfile, result.IdEvent, result.Position,
                result.Points, result.Status, result.Time, result.EventQualification);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
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
