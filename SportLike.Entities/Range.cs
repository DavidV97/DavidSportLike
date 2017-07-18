using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Range : BaseEntity
    {
        public Range() { GetClassInfo(); }

        public Range(int idRange, int idEvent, int initialRange, int finalRange, int points)
        {
            this.IdRange = idRange;
            this.IdEvent = idEvent;
            this.InitialRange = initialRange;
            this.FinalRange = finalRange;
            this.Points = points;
        }

        public int IdRange { get; set; }
        public int IdEvent { get; set; }
        public int InitialRange { get; set; }
        public int FinalRange { get; set; }
        public int Points { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Range).GetProperties();
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
            var range = (Range)entity;
            return new List<object>(new object[] { range.IdRange, range.IdEvent, range.InitialRange,
                range.FinalRange, range.Points });
        }
    }
}
