﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Suppliers
{
    public class GetRequestData : IRequestData
    {
        public string SupplierID { get; set; }

    }
}