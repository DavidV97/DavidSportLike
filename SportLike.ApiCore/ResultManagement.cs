﻿using SportLife.DataAccess.Crud;
using SportLike.ApiCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.ApiCore
{
    public class ResultManagement : BaseManagement
    {
        public ResultManagement()
        {
            crudFactory = new CrudResult();
        }
    }
}
