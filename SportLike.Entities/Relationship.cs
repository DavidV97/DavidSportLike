using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Relationship : BaseEntity
    {
        public Relationship() { GetClassInfo(); }

        public Relationship(int idRelationship, string idAdmin, string idProfile, string status, string type)
        {
            this.IdRelationship = idRelationship;
            this.IdAdmin = idAdmin;
            this.IdProfile = idProfile;
            this.Status = status;
            this.Type = type;
        }

        public int IdRelationship { get; set; }
        public string IdAdmin { get; set; }
        public string IdProfile { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Relationship).GetProperties();
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
            var relation = (Relationship)entity;
            return new List<object>(new object[] { relation.IdRelationship, relation.IdAdmin,
                relation.IdProfile, relation.Status, relation.Type});
        }
    }
}
