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
    public class InscriptionInfoMapper : EntityMapper
    {
        public InscriptionInfoMapper() { ClassName = "INSCRIPTION_INFO"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            InscriptionInfo inscInfo = new InscriptionInfo();

            keyList = new List<string>(inscInfo.ClassInfo.Keys);

            var IdInscriptionInfo = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[1]));
            var InitialDate = GetDateValue(row, ToSnakeCase(keyList[2]));
            var FinalDate = GetDateValue(row, ToSnakeCase(keyList[3]));
            var EventCost = GetIntValue(row, ToSnakeCase(keyList[4]));
            var InscriptionCost = GetIntValue(row, ToSnakeCase(keyList[5]));
            var Discount = GetIntValue(row, ToSnakeCase(keyList[6]));

            return new InscriptionInfo(IdInscriptionInfo, IdEvent, InitialDate, FinalDate,
                EventCost, InscriptionCost, Discount);
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
                return new List<int>(new int[] { 1 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
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
