﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteDiscountRequestData : IRequestData
    {
        public string DiscountID { get; set; }

    }
}