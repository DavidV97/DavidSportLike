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
    public class EventMapper : EntityMapper
    {
        public EventMapper() { ClassName = "EVENT"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Event events = new Event();

            keyList = new List<string>(events.ClassInfo.Keys);

            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdCategory = GetIntValue(row, ToSnakeCase(keyList[2]));
            var IdAddress = GetIntValue(row, ToSnakeCase(keyList[3]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[4]));
            var InitialDate = GetDateValue(row, ToSnakeCase(keyList[5]));
            var FinalDate = GetDateValue(row, ToSnakeCase(keyList[6]));
            var Description = GetStringValue(row, ToSnakeCase(keyList[7]));
            var Type = GetStringValue(row, ToSnakeCase(keyList[8]));
            var CantParticipants = GetIntValue(row, ToSnakeCase(keyList[9]));
            var ImgURL = GetStringValue(row, ToSnakeCase(keyList[10]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[11]));

            return new Event(IdEvent, IdProfile, IdCategory, IdAddress, Name, InitialDate,
                FinalDate, Description, Type, CantParticipants, ImgURL, Active);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
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
