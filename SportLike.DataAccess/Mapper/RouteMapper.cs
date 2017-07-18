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
    public class RouteMapper : EntityMapper
    {
        public RouteMapper() { ClassName = "ROUTE"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Route route = new Route();

            keyList = new List<string>(route.ClassInfo.Keys);

            var IdRoute = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[1]));
            var InitialAddress = GetIntValue(row, ToSnakeCase(keyList[2]));
            var FinalAddress = GetIntValue(row, ToSnakeCase(keyList[3]));

            return new Route(route.IdRoute, route.IdEvent, route.InitialAddress, route.FinalAddress);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 1 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 ,3});
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
