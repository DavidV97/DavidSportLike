using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class InscriptionInfo : BaseEntity
    {
        public InscriptionInfo() { GetClassInfo(); }
        public InscriptionInfo(int idInscriptionInfo, int idEvent, DateTime initialDate, DateTime finalDate, int eventCost, int inscriptionCost, int discount)
        {
            this.IdInscriptionInfo = idInscriptionInfo;
            this.IdEvent = idEvent;
            this.InitialDate = initialDate;
            this.FinalDate = finalDate;
            this.EventCost = eventCost;
            this.InscriptionCost = inscriptionCost;
            this.Discount = discount;
        }
        public int IdInscriptionInfo { get; set; }
        public int IdEvent { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int EventCost { get; set; }
        public int InscriptionCost { get; set; }
        public int Discount { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(InscriptionInfo).GetProperties();
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
            var inscInfo = (InscriptionInfo)entity;
            return new List<object>(new object[] { inscInfo.IdInscriptionInfo, inscInfo.IdEvent, inscInfo.InitialDate,
            inscInfo.FinalDate, inscInfo.EventCost, inscInfo.InscriptionCost, inscInfo.Discount });
        }
    }
}
