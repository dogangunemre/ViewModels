﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class GetRequestData:IRequestData
    {
        public string CustomerID { get; set; }
    }
}