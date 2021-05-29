﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Manufacturers
{
    public class DeleteRequestData : IRequestData
    {
        public string ManufacturerID { get; set; }
    }
}