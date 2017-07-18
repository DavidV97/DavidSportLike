using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Spectator : BaseEntity
    {
        public Spectator() { GetClassInfo(); }

        public Spectator(int idSpectator, int idEvent, string name, string email, string phone, string seatNumber, bool active)
        {
            this.IdSpectator = idSpectator;
            this.IdEvent = idEvent;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.SeatNumber = seatNumber;
            this.Active = active;
        }

        public int IdSpectator { get; set; }
        public int IdEvent { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SeatNumber { get; set; }
        public bool Active { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Spectator).GetProperties();
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
            var spectator = (Spectator)entity;
            return new List<object>(new object[] { spectator.IdSpectator, spectator.IdEvent, spectator.Name,
                spectator.Email, spectator.Phone, spectator.SeatNumber, spectator.Active});
        }
    }
}
