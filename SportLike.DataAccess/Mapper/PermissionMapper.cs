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
    public class PermissionMapper : EntityMapper
    {
        public PermissionMapper() { ClassName = "PERMISSION"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Permission permission = new Permission();

            keyList = new List<string>(permission.ClassInfo.Keys);

            var IdPermission = GetIntValue(row, ToSnakeCase(keyList[0]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[1]));
            var Code = GetStringValue(row, ToSnakeCase(keyList[2]));

            return new Permission(permission.IdPermission, permission.Name, permission.Code);
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
