using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Inscription : BaseEntity
    {
        public Inscription() { GetClassInfo(); }

        public Inscription(int idInscription, string idProfile, int idEvent, bool statusPackage)
        {
            this.IdInscription = idInscription;
            this.IdProfile = idProfile;
            this.IdEvent = idEvent;
            this.StatusPackage = statusPackage;
        }
        public int IdInscription { get; set; }
        public string IdProfile { get; set; }
        public int IdEvent { get; set; }
        public bool StatusPackage { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Inscription).GetProperties();
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
            var inscription = (Inscription)entity;
            return new List<object>(new object[] { inscription.IdInscription, inscription.IdProfile,
                inscription.IdEvent, inscription.StatusPackage});
        }
    }
}
