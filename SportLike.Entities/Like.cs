using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Like : BaseEntity
    {
        public Like() { GetClassInfo(); }

        public Like(int idLike, int idPublication, string idProfile, bool active)
        {
            this.IdLike = idLike;
            this.IdPublication = idPublication;
            this.IdProfile = idProfile;
            this.Active = active;
        }

        public int IdLike { get; set; }
        public int IdPublication { get; set; }
        public string IdProfile { get; set; }
        public bool Active { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Like).GetProperties();
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
            var like = (Like)entity;
            return new List<object>(new object[] { like.IdLike, like.IdPublication,
                like.IdProfile, like.Active });
        }
    }
}
