﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class CountNewOnesResponseData:IResponseData
    {
        public long Count { get; set; }
    }
}