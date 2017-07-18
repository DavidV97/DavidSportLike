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
    public class PayInfoMapper : EntityMapper
    {
        public PayInfoMapper() { ClassName = "PAY_INFO"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            PayInfo payInfo = new PayInfo();

            keyList = new List<string>(payInfo.ClassInfo.Keys);

            var IdPayInfo = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdSpectator = GetIntValue(row, ToSnakeCase(keyList[2]));
            var IdPaymentMethod = GetIntValue(row, ToSnakeCase(keyList[3]));
            var Email = GetStringValue(row, ToSnakeCase(keyList[4]));
            var NameCard = GetStringValue(row, ToSnakeCase(keyList[5]));
            var CardNumber = GetIntValue(row, ToSnakeCase(keyList[6]));
            var ExpirationDate = GetDateValue(row, ToSnakeCase(keyList[6]));

            return new PayInfo(payInfo.IdPayInfo, payInfo.IdProfile, payInfo.IdSpectator, payInfo.IdPaymentMethod,
                payInfo.Email, payInfo.NameCard, payInfo.CardNumber, payInfo.ExpirationDate);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            }
            else if (procName == "DEL_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 });
            }
            else
            {
                return null;
            }
        }
    }
}
