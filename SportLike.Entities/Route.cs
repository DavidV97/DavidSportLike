using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Route : BaseEntity
    {
        public Route() { GetClassInfo(); }
        public Route(int idRoute, int idEvent, int initialAddress, int finalAddress)
        {
            this.IdRoute = idRoute;
            this.IdEvent = idEvent;
            this.InitialAddress = initialAddress;
            this.FinalAddress = finalAddress;
        }
        public int IdRoute { get; set; }
        public int IdEvent { get; set; }
        public int InitialAddress { get; set; }
        public int FinalAddress { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Route).GetProperties();
            foreach (PropertyInfo prop in props)
            {
                string propName = prop.Name;
                string type = prop.PropertyType.Name;
                ClassInfo.Add(propName, type);
            }
            return ClassInfo;
        }
        public override List<object> GetClassVal(BaseEntity entity)
        {
            var route = (Route)entity;
            return new List<object>(new object[] { route.IdRoute,route.IdEvent, route.InitialAddress,
                route.FinalAddress });
        }
    }
}
