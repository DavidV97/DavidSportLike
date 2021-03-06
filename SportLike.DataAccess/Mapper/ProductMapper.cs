﻿using SportLife.Entities;
using SportLike.DataAccess.Dao;
using SportLike.DataAccess.Mapper;
using SportLike.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Mapper
{
    public class ProductMapper : EntityMapper
    {
        public ProductMapper() { ClassName = "PRODUCT"; }
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            Product product = new Product();

            keyList = new List<string>(product.ClassInfo.Keys);

            var IdProduct = GetIntValue(row, ToSnakeCase(keyList[0]));
            var Name = GetStringValue(row, ToSnakeCase(keyList[1]));
            var Description = GetStringValue(row, ToSnakeCase(keyList[2]));
            var ImgUrl = GetStringValue(row, ToSnakeCase(keyList[3]));
            var Active = GetBooleanValue(row, ToSnakeCase(keyList[4]));

            return new Product(product.IdProduct, product.Name, product.Description,
                product.ImgUrl, product.Active);
        }
        public override List<int> GetReqValus(string procName)
        {
            if (procName == "CRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RCRE_" + ClassName)
            {
                return new List<int>(new int[] { 1, 2, 3 });
            }
            else if (procName == "RET_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else if (procName == "UPD_" + ClassName)
            {
                return new List<int>(new int[] { 0, 1, 2, 3, 4 });
            }
            else if (procName == "DEL_" + ClassName)
            {
                return new List<int>(new int[] { 0 });
            }
            else
            {
                return null;
            }
        }
    }
}
