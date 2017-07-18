using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public PaymentMethod() { GetClassInfo(); }

        public PaymentMethod(int idPaymentMethod, string name)
        {
            this.IdPaymentMethod = idPaymentMethod;
            this.Name = name;
        }

        public int IdPaymentMethod { get; set; }
        public string Name { get; set; }
        public override Dictionary<string, string> GetClassInfo()
        {
            PropertyInfo[] props = typeof(PaymentMethod).GetProperties();
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
            var payMethod = (PaymentMethod)entity;
            return new List<object>(new object[] { payMethod.IdPaymentMethod, payMethod.Name });
        }
    }
}
