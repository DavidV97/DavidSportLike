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
    public class ProfileMapper : EntityMapper
    {
        public ProfileMapper() { ClassName = "PROFILE"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Profile profile = new Profile();

            keyList = new List<string>(profile.ClassInfo.Keys);

            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[0]));
            var IdAddress = GetIntValue(row, ToSnakeCase(keyList[1]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[2]));
            var Birthdate = GetDateValue(row, ToSnakeCase(keyList[3]));
            var Email = GetStringValue(row, ToSnakeCase(keyList[4]));
            var Password = GetStringValue(row, ToSnakeCase(keyList[5]));
            var ImgUrl = GetStringValue(row, ToSnakeCase(keyList[6]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[7]));

            return new Profile(profile.IdProfile, profile.IdAddress, profile.Name, profile.Birthdate,
                profile.Email, profile.Password, profile.ImgUrl, profile.Active);
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
