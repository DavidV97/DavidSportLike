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
    public class PublicationMapper : EntityMapper
    {
        public PublicationMapper() { ClassName = "PUBLICATION"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Publication publication = new Publication();

            keyList = new List<string>(publication.ClassInfo.Keys);

            var IdPublication = GetIntValue(row, ToSnakeCase(keyList[0]));
            var IdProfile = GetStringValue(row, ToSnakeCase(keyList[1]));
            var IdEvent = GetIntValue(row, ToSnakeCase(keyList[2]));
            var Date = GetDateValue(row, ToSnakeCase(keyList[3]));
            var Description = GetStringValue(row, ToSnakeCase(keyList[4]));
            var Type = GetStringValue(row, ToSnakeCase(keyList[5]));
            var ImgUrl = GetStringValue(row, ToSnakeCase(keyList[6]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[7]));
            var IdComment = GetIntValue(row, ToSnakeCase(keyList[8]));

            return new Publication(publication.IdPublication, publication.IdProfile, publication.IdEvent,
                publication.Date, publication.Description, publication.Type, publication.ImgUrl, publication.Active,
                publication.IdComment);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 8 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 8 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
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
