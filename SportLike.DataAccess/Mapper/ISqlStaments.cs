using SportLike.DataAccess.Dao;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLike.DataAccess.Mapper
{
    internal interface ISqlStaments
    {
        SqlOperation GetCreateStatement(BaseEntity entity);
        SqlOperation GetRCreateStatement(BaseEntity entity);
        SqlOperation GetRetriveStatement(BaseEntity entity);
        SqlOperation GetRetriveAllStatement();
        SqlOperation GetUpdateStatement(BaseEntity entity);
        SqlOperation GetDeleteStatement(BaseEntity entity);
    }
}
