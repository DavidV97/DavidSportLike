using SportLike.DataAccess.Dao;
using SportLike.DataAccess.Mapper;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportLike.DataAccess.Crud
{
    public class CrudFactory
    {
        protected EntityMapper EntityMapper { get; set; }
        public bool Create(BaseEntity entity)
        {
            var instance = SqlDao.GetInstance();
            var operation = EntityMapper.GetCreateStatement(entity);
            instance.ExecuteProcedure(operation);
            return true;
        }
        public T RCreate<T>(BaseEntity entity)
        {
            var instance = SqlDao.GetInstance();
            var operation = EntityMapper.GetRCreateStatement(entity);

            var lstResult = instance.ExecuteQueryProcedure(operation);

            if (lstResult.Count <= 0) return default(T);

            var dic = lstResult[0];
            var objs = EntityMapper.BuildObject(dic);

            return (T)Convert.ChangeType(objs, typeof(T));
        }
        public T Retrieve<T>(BaseEntity entity)
        {
            var instance = SqlDao.GetInstance();
            var operation = EntityMapper.GetRetriveStatement(entity);
            var lstResult = instance.ExecuteQueryProcedure(operation);

            if (lstResult.Count <= 0) return default(T);

            var dic = lstResult[0];
            var obj = EntityMapper.BuildObjects(lstResult);

            return obj.Cast<T>().ToList()[0];
        }
        public List<T> RetrieveAll<T>()
        {
            var lstResult = SqlDao.GetInstance().ExecuteQueryProcedure(EntityMapper.GetRetriveAllStatement());

            if (lstResult.Count <= 0) return default(List<T>);
            var obj = EntityMapper.BuildObjects(lstResult);
            return obj.Cast<T>().ToList();
        }
        public bool Update(BaseEntity entity)
        {
            var operation = EntityMapper.GetUpdateStatement(entity);
            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);
            return true;
        }
        public bool Delete(BaseEntity entity)
        {
            var operation = EntityMapper.GetDeleteStatement(entity);
            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);
            return true;
        }
    }
}
