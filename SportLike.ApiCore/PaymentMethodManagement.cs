﻿using SportLife.DataAccess;
using SportLike.ApiCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.ApiCore
{
    public class PaymentMethodManagement : BaseManagement
    {
        public PaymentMethodManagement()
        {
            crudFactory = new CrudPaymentMethod();
        }
    }
}
