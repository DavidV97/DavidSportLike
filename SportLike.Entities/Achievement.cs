using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Achievement : BaseEntity
    {
        public Achievement() { GetClassInfo(); }

        public Achievement(int idAchievement, string name, string description, int points, string imgUrl, bool active)
        {
            this.IdAchievement = idAchievement;
            this.Name = name;
            this.Description = description;
            this.Points = points;
            this.ImgUrl = imgUrl;
            this.Active = active;
        }

        public int IdAchievement { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string ImgUrl { get; set; }
        public bool Active { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Achievement).GetProperties();
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
            var achiev = (Achievement)entity;
            return new List<object>(new object[] { achiev.IdAchievement, achiev.Name, achiev.Description,
                achiev.Points, achiev.ImgUrl, achiev.Active });
        }
    }
}
