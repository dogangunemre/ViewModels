﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class GetResponseData : IResponseData
    {
        public ProductBasic Product { get; set; }

    }
}