using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Binnacle : BaseEntity
    {
        public Binnacle() { GetClassInfo(); }

        public Binnacle(int idBinnacle, string idProfile, DateTime date, string description)
        {
            this.IdBinnacle = idBinnacle;
            this.IdProfile = idProfile;
            this.Date = date;
            this.Description = description;
        }

        public int IdBinnacle { get; set; }
        public string IdProfile { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Binnacle).GetProperties();
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
            var binncle = (Binnacle)entity;
            return new List<object>(new object[] { binncle.IdBinnacle, binncle.IdProfile,
                binncle.Date, binncle.Description });
        }
    }
}
