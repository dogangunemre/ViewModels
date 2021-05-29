﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts
{

    public class AddNewResponseViewModel:ResponseViewModel<AddNewRequestData,AddNewResponseData>
    {
        public AddNewResponseViewModel() : base()
        {

        }
        public AddNewResponseViewModel(AddNewRequestData RequestData):base(RequestData)
        {
            
        }

    }
}