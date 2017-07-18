using SportLife.DataAccess.Mapper;
using SportLike.DataAccess.Crud;
using SportLike.DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Crud
{
    public class CrudEvent : CrudFactory
    {
        public CrudEvent()
        {
            EntityMapper = new EventMapper();
        }
    }
}
