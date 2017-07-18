using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Permission : BaseEntity
    {
        public Permission() { GetClassInfo(); }

        public Permission(int idPermission, string name, string code)
        {
            this.IdPermission = idPermission;
            this.Name = name;
            this.Code = code;
        }

        public int IdPermission { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Permission).GetProperties();
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
            var permission = (Permission)entity;
            return new List<object>(new object[] { permission.IdPermission, permission.Code,
                permission.Code});
        }
    }
}
