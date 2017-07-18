using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLike.Entities
{
    public abstract class BaseEntity
    {
        public Dictionary<string, string> ClassInfo = new Dictionary<string, string>();
        public abstract Dictionary<string, string> GetClassInfo();
        public abstract List<object> GetClassVal(BaseEntity entity);
    }
}
