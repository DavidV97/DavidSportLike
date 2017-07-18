using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Event : BaseEntity
    {
        public Event() { GetClassInfo(); }
        public Event(int idEvent, string idProfile, int idCategory, int idAddress, string name,
            DateTime initialDate, DateTime finalDate, string description, string type, int cantParticipants,
            string imgURL, bool active)
        {
            GetClassInfo();
            this.IdEvent = idEvent;
            this.IdProfile = idProfile;
            this.IdCategory = idCategory;
            this.IdAddress = idAddress;
            this.Name = name;
            this.InitialDate = initialDate;
            this.FinalDate = finalDate;
            this.Description = description;
            this.Type = type;
            this.CantParticipants = cantParticipants;
            this.ImgURL = imgURL;
            this.Active = active;
        }

        public int IdEvent { get; set; }
        public string IdProfile { get; set; }
        public int IdCategory { get; set; }
        public int IdAddress { get; set; }
        public string Name { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int CantParticipants { get; set; }
        public string ImgURL { get; set; }
        public bool Active { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Event).GetProperties();
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
            var events = (Event)entity;
            return new List<object>(new object[] { events.IdEvent, events.IdProfile, events.IdCategory, events.IdAddress,
                events.Name, events.InitialDate, events.FinalDate, events.Description, events.Type,
                events.CantParticipants,events.ImgURL, events.Active });
        }
    }
}
