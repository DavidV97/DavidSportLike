using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Profile : BaseEntity
    {
        public Profile() { GetClassInfo(); }

        public Profile(string idProfile, int idAddress, string name, DateTime birthdate, string email, string password, string imgUrl, bool active)
        {
            this.IdProfile = idProfile;
            this.IdAddress = idAddress;
            this.Name = name;
            this.Birthdate = birthdate;
            this.Email = email;
            this.Password = password;
            this.ImgUrl = imgUrl;
            this.Active = active;
        }

        public string IdProfile { get; set; }
        public int IdAddress { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImgUrl { get; set; }
        public bool Active { get; set; }


        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Profile).GetProperties();
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
            var profile = (Profile)entity;
            return new List<object>(new object[] { profile.IdProfile, profile.IdAddress, profile.Name,
                profile.Birthdate, profile.Email, profile.Password, profile.ImgUrl, profile.Active});
        }
    }
}
