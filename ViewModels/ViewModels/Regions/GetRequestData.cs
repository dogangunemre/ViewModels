﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class GetRequestData : IRequestData
    {
        public string RegionID { get; set; }
    }
}