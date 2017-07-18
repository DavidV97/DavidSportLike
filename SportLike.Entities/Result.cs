using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Result : BaseEntity
    {
        public Result() { GetClassInfo(); }

        public Result(int idResult, string idProfile, int idEvent, int position, int points, string status, DateTime time, int eventQualification)
        {
            this.IdResult = idResult;
            this.IdProfile = idProfile;
            this.IdEvent = idEvent;
            this.Position = position;
            this.Points = points;
            this.Status = status;
            this.Time = time;
            this.EventQualification = eventQualification;
        }

        public int IdResult { get; set; }
        public string IdProfile { get; set; }
        public int IdEvent { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
        public int EventQualification { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Result).GetProperties();
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
            var result = (Result)entity;
            return new List<object>(new object[] { result.IdResult, result.IdProfile, result.IdEvent,
                result.Position, result.Points, result.Status, result.Time, result.EventQualification});
        }
    }
}
