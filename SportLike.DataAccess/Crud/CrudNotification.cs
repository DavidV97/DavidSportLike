using SportLife.DataAccess.Mapper;
using SportLike.DataAccess.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess
{
    public class CrudNotification : CrudFactory
    {
        public CrudNotification()
        {
            EntityMapper = new NotificationMapper();
        }
    }
}
