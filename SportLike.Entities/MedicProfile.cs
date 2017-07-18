using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class MedicProfile : BaseEntity
    {
        public MedicProfile() { GetClassInfo(); }

        public MedicProfile(int idMedicProfile, string idProfile, string diseasesSuffred, string relativesPhone)
        {
            this.IdMedicProfile = idMedicProfile;
            this.IdProfile = idProfile;
            this.DiseasesSuffred = diseasesSuffred;
            this.RelativesPhone = relativesPhone;
        }

        public int IdMedicProfile { get; set; }
        public string IdProfile { get; set; }
        public string DiseasesSuffred { get; set; }
        public string RelativesPhone { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(MedicProfile).GetProperties();
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
            var medicProfile = (MedicProfile)entity;
            return new List<object>(new object[] { medicProfile.IdMedicProfile, medicProfile.IdProfile,
                medicProfile.DiseasesSuffred, medicProfile.RelativesPhone});
        }
    }
}
