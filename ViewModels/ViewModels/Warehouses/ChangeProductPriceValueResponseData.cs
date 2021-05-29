﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class ChangeProductPriceValueResponseData:IResponseData
    {
        public PriceBasic Price { get; set; }
    }
}