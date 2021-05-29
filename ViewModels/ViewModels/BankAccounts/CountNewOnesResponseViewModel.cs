﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts
{

    public class CountNewOnesResponseViewModel:ResponseViewModel<CountNewOnesRequestData,CountNewOnesResponseData>
    {
        public CountNewOnesResponseViewModel() : base()
        {

        }
        public CountNewOnesResponseViewModel(CountNewOnesRequestData RequestData):base(RequestData)
        {
            
        }

    }
}