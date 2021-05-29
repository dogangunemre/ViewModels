﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class AddNewProductPriceRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public PriceBasic Price { get; set; }
    }
}