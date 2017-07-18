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
    public class AddressMapper : EntityMapper
    {
        public AddressMapper() { ClassName = "ADDRESS"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Address address = new Address();

            keyList = new List<string>(address.ClassInfo.Keys);

            var IdAddress = GetIntValue(row, ToSnakeCase(keyList[0]));
            var Latitude = GetIntValue(row, ToSnakeCase(keyList[1]));
            var Longitude = GetIntValue(row, ToSnakeCase(keyList[2]));

            return new Address(address.IdAddress, address.Latitude, address.Longitude);
        }
        public new SqlOperation GetRetriveAllStatement()
        {
            return new SqlOperation("RET_" + ClassName + "ES");
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
                return new List<int>(new int[] { 0, 1, 2 });
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
