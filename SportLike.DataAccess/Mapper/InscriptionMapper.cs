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
    public class InscriptionMapper : EntityMapper
    {
        public InscriptionMapper() { ClassName = "INSCRIPTION"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Inscription inscription = new Inscription();

            keyList = new List<string>(inscription.ClassInfo.Keys);

            var IdInscription = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[2]));
            var StatusPackage = GetBooleanValue(row, ToSnakeCase(keyList[3]));

            return new Inscription(inscription.IdInscription, inscription.IdProfile,
                inscription.IdEvent, inscription.StatusPackage);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3 });
            }
            else if (procName == "DEL_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else
            {
                return null;
            }
        }
    }
}
