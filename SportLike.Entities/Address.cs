using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Address : BaseEntity
    {
        public Address() { GetClassInfo(); }

        public Address(int idAddress, int latitude, int longitude)
        {
            this.IdAddress = idAddress;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public int IdAddress { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Address).GetProperties();
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
            var address = (Address)entity;
            return new List<object>(new object[] { address.IdAddress, address.Latitude,
                address.Longitude});
        }
    }
}
