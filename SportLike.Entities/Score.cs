using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Score : BaseEntity
    {
        public Score() { GetClassInfo(); }

        public Score(int idScore, string idProfile, int points)
        {
            this.IdScore = idScore;
            this.IdProfile = idProfile;
            this.Points = points;
        }

        public int IdScore { get; set; }
        public string IdProfile { get; set; }
        public int Points { get; set; }
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
            var score = (Score)entity;
            return new List<object>(new object[] { score.IdScore, score.IdProfile,
                score.Points });
        }
    }
}
