using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Product : BaseEntity
    {
        public Product() { GetClassInfo(); }

        public Product(int idProduct, string name, string description, string imgUrl, bool active)
        {
            this.IdProduct = idProduct;
            this.Name = name;
            this.Description = description;
            this.ImgUrl = imgUrl;
            this.Active = active;
        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public bool Active { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Product).GetProperties();
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
            var product = (Product)entity;
            return new List<object>(new object[] { product.IdProduct, product.Name,
                product.Description, product.ImgUrl, product.Active});
        }
    }
}
