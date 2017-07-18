using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class PayInfo : BaseEntity
    {
        public PayInfo() { GetClassInfo(); }

        public PayInfo(int idPayInfo, string idProfile, int idSpectator, int idPaymentMethod, string email, string nameCard, int cardNumber, DateTime expirationDate)
        {
            this.IdPayInfo = idPayInfo;
            this.IdProfile = idProfile;
            this.IdSpectator = idSpectator;
            this.IdPaymentMethod = idPaymentMethod;
            this.Email = email;
            this.NameCard = nameCard;
            this.CardNumber = cardNumber;
            this.ExpirationDate = expirationDate;
        }

        public int IdPayInfo { get; set; }
        public string IdProfile { get; set; }
        public int IdSpectator { get; set; }
        public int IdPaymentMethod { get; set; }
        public string Email { get; set; }
        public string NameCard { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(Route).GetProperties();
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
            var payInfo = (PayInfo)entity;
            return new List<object>(new object[] { payInfo.IdPayInfo, payInfo.IdProfile, payInfo.IdSpectator,
                payInfo.IdPaymentMethod, payInfo.Email, payInfo.NameCard, payInfo.CardNumber, payInfo.ExpirationDate });
        }
    }
}
