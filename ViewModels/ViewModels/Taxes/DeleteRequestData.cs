﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Taxes
{
    public class DeleteRequestData:IRequestData
    {
        public string TaxID { get; set; }
    }
}