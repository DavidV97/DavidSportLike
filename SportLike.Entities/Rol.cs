using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Rol : BaseEntity
    {
        public Rol() { GetClassInfo(); }

        public Rol(int idRol, string name)
        {
            this.IdRol = idRol;
            this.Name = name;
        }

        public int IdRol { get; set; }
        public string Name { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Rol).GetProperties();
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
            var rol = (Rol)entity;
            return new List<object>(new object[] { rol.IdRol, rol.Name });
        }
    }
}
