﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Brands
{
    public class GetRequestData:IRequestData
    {
        public string BrandID { get; set; }

    }
}