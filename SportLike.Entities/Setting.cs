using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class Setting : BaseEntity
    {
        public Setting() { GetClassInfo(); }

        public Setting(int idSetting, string termsConditions)
        {
            this.IdSetting = idSetting;
            this.TermsConditions = termsConditions;
        }

        public int IdSetting { get; set; }
        public string TermsConditions { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Setting).GetProperties();
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
            var setting = (Setting)entity;
            return new List<object>(new object[] { setting.IdSetting, setting.TermsConditions });
        }
    }
}
