using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Notification : BaseEntity
    {
        public Notification() { GetClassInfo(); }

        public Notification(int idNotification, string idProfile, int idEvent, string description)
        {
            this.IdNotification = idNotification;
            this.IdProfile = idProfile;
            this.IdEvent = idEvent;
            this.Description = description;
        }

        public int IdNotification { get; set; }
        public string IdProfile { get; set; }
        public int IdEvent { get; set; }
        public string Description { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Notification).GetProperties();
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
            var notification = (Notification)entity;
            return new List<object>(new object[] { notification.IdNotification, notification.IdProfile,
                notification.IdEvent, notification.Description});
        }
    }
}
