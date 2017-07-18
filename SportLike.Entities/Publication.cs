using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Publication : BaseEntity
    {
        public Publication() { GetClassInfo(); }

        public Publication(int idPublication, string idProfile, int idEvent, DateTime date, string description, string type, string imgUrl, bool active, int idComment)
        {
            this.IdPublication = idPublication;
            this.IdProfile = idProfile;
            this.IdEvent = idEvent;
            this.Date = date;
            this.Description = description;
            this.Type = type;
            this.ImgUrl = imgUrl;
            this.Active = active;
            this.IdComment = idComment;
        }

        public int IdPublication { get; set; }
        public string IdProfile { get; set; }
        public int IdEvent { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string ImgUrl { get; set; }
        public bool Active { get; set; }
        public int IdComment { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Publication).GetProperties();
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
            var publication = (Publication)entity;
            return new List<object>(new object[] { publication.IdPublication, publication.IdProfile,
                publication.IdEvent, publication.Date, publication.Description, publication.Type,
                publication.ImgUrl, publication.Active, publication.IdComment});
        }
    }
}
