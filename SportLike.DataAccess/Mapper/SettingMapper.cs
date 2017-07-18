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
    public class SettingMapper : EntityMapper
    {
        public SettingMapper() { ClassName = "SETTING"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Setting setting = new Setting();

            keyList = new List<string>(setting.ClassInfo.Keys);

            var IdSetting = GetIntValue(row, ToSnakeCase(keyList[0]));
            var TermsConditions = GetStringValue(row, ToSnakeCase(keyList[1]));

            return new Setting(setting.IdSetting, setting.TermsConditions);
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
