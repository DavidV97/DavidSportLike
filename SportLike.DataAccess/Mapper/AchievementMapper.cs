﻿using SportLife.Entities;
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
    public class AchievementMapper : EntityMapper
    {
        public AchievementMapper() { ClassName = "ACHIEVEMENT"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Achievement achiev = new Achievement();

            keyList = new List<string>(achiev.ClassInfo.Keys);

            var IdAchievement = GetIntValue(row, ToSnakeCase(keyList[0]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[1]));
            var Description = GetStringValue(row, ToSnakeCase(keyList[2]));
            var Points = GetIntValue(row, ToSnakeCase(keyList[3]));
            var ImgUrl = GetStringValue(row, ToSnakeCase(keyList[4]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[5]));

            return new Achievement(achiev.IdAchievement, achiev.Name, achiev.Description,
                achiev.Points, achiev.ImgUrl, achiev.Active);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4});
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
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
