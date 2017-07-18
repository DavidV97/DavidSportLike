using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Category : BaseEntity
    {
        public Category() { GetClassInfo(); }

        public Category(int idCategory, string name)
        {
            this.IdCategory = idCategory;
            this.Name = name;
        }

        public int IdCategory { get; set; }
        public string Name { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Category).GetProperties();
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
            var category = (Category)entity;
            return new List<object>(new object[] { category.IdCategory, category.Name });
        }
    }
}
