using SportLife.Entities;
using SportLike.DataAccess.Mapper;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Mapper
{
    public class RangeMapper : EntityMapper
    {
        public RangeMapper() { ClassName = "RANGE"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Range range = new Range();

            keyList = new List<string>(range.ClassInfo.Keys);

            var IdRange = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[1]));
            var InitialRange = GetIntValue(row, ToSnakeCase(keyList[2]));
            var FinalRange = GetIntValue(row, ToSnakeCase(keyList[3]));
            var Points = GetIntValue(row, ToSnakeCase(keyList[4]));

            return new Range(range.IdRange, range.IdEvent, range.InitialRange, range.FinalRange, range.Points);
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
                return new List<int>(new int[] { 1 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4 });
            }
            else if (procName == "DEL_" + ClassName)
            {
                return new List<int>(new int[] { 1 });
            }
            else
            {
                return null;
            }
        }
    }
}
