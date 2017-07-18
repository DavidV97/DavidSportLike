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
    public class SpectatorMapper : EntityMapper
    {
        public SpectatorMapper() { ClassName = "SPECTATOR"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Spectator spectator = new Spectator();

            keyList = new List<string>(spectator.ClassInfo.Keys);

            var IdSpectator = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[1]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[2]));
            var Email = GetStringValue(row, ToSnakeCase(keyList[3]));
            var Phone = GetStringValue(row, ToSnakeCase(keyList[4]));
            var SeatNumber = GetStringValue(row, ToSnakeCase(keyList[5]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[6]));

            return new Spectator(spectator.IdSpectator, spectator.IdEvent, spectator.Name,
                spectator.Email, spectator.Phone, spectator.SeatNumber, spectator.Active);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });
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
