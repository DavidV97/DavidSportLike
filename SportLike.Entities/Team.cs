using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Team : BaseEntity
    {
        public Team() { GetClassInfo(); }

        public Team(int idTeam, string name, string description, string type, string imgUrl, bool active)
        {
            this.IdTeam = idTeam;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.ImgUrl = imgUrl;
            this.Active = active;
        }

        public int IdTeam { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string ImgUrl { get; set; }
        public bool Active { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Team).GetProperties();
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
            var team = (Team)entity;
            return new List<object>(new object[] { team.IdTeam, team.Name,
                team.Description, team.Type, team.ImgUrl, team.Active});
        }
    }
}
