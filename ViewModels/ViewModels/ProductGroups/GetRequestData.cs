﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductGroups
{
    public class GetRequestData:IRequestData
    {
        public string ProductGroupID { get; set; }

    }
}