using SportLife.Entities;
using SportLike.DataAccess.Dao;
using SportLike.DataAccess.Mapper;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Mapper
{
    public class MedicProfileMapper : EntityMapper
    {
        public MedicProfileMapper() { ClassName = "MEDIC_PROFILE"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            MedicProfile medicProfile = new MedicProfile();

            keyList = new List<string>(medicProfile.ClassInfo.Keys);

            var IdMedicProfile = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var DiseasesSuffred = GetStringValue(row, ToSnakeCase(keyList[2]));
            var RelativesPhone = GetStringValue(row, ToSnakeCase(keyList[3]));

            return new MedicProfile(medicProfile.IdMedicProfile, medicProfile.IdProfile,
                medicProfile.DiseasesSuffred, medicProfile.RelativesPhone);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 1 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "DEL_" + ClassName)
            {
                return new List<int>(new int[] { 1 });
            }
            else
            {
                return null;
            }
        }
    }
}
