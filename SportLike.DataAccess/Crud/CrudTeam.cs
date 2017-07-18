using SportLife.DataAccess.Mapper;
using SportLike.DataAccess.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess
{
    public class CrudTeam : CrudFactory
    {
        public CrudTeam()
        {
            EntityMapper = new TeamMapper();
        }
    }
}
