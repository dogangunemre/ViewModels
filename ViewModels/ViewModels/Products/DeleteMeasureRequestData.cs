﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteMeasureRequestData : IRequestData
    {
        public string MeasureID { get; set; }

    }
}