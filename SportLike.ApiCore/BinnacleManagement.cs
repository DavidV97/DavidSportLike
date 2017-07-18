﻿using SportLife.DataAccess.Crud;
using SportLike.ApiCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.ApiCore
{
    public class BinnacleManagement : BaseManagement
    {
        public BinnacleManagement()
        {
            crudFactory = new CrudBinnacle();
        }
    }
}
