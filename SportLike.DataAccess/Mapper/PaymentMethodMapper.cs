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
    public class PaymentMethodMapper : EntityMapper
    {
        public PaymentMethodMapper() { ClassName = "PAYMENT_METHOD"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            PaymentMethod payMethod = new PaymentMethod();

            keyList = new List<string>(payMethod.ClassInfo.Keys);

            var IdPaymentMethod = GetIntValue(row, ToSnakeCase(keyList[0]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[1]));

            return new PaymentMethod(payMethod.IdPaymentMethod, payMethod.Name);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1 });
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
