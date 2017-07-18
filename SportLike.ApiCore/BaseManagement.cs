using SportLike.DataAccess.Crud;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLike.ApiCore
{
    public class BaseManagement
    {
        protected CrudFactory crudFactory { get; set; }
        //protected ExceptionManagement _exceptionManagement;

        public void Create(BaseEntity entity)
        {
            crudFactory.Create(entity);
        }

        public BaseEntity RCreate(BaseEntity entity)
        {
            return crudFactory.RCreate<BaseEntity>(entity);
        }

        public BaseEntity Retrieve(BaseEntity entity)
        {
            return crudFactory.Retrieve<BaseEntity>(entity);
        }
        public List<BaseEntity> RetrieveAll()
        {
            return crudFactory.RetrieveAll<BaseEntity>();
        }

        public bool Update(BaseEntity entity)
        {
            return crudFactory.Update(entity);
        }

        public bool Delete(BaseEntity entity)
        {
            return crudFactory.Delete(entity);
        }
    }
}
