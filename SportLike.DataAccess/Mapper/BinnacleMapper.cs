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
    public class BinnacleMapper : EntityMapper
    {
        public BinnacleMapper() { ClassName = "BINNCLE"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Binnacle binncle = new Binnacle();

            keyList = new List<string>(binncle.ClassInfo.Keys);

            var IdBinnacle = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var Date = GetDateValue(row, ToSnakeCase(keyList[2]));
            var Description = GetStringValue(row, ToSnakeCase(keyList[3]));

            return new Binnacle(binncle.IdBinnacle, binncle.IdProfile, binncle.Date, binncle.Description);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
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
