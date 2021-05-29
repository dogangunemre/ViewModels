﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeOptionsValueResponseData : IResponseData
    {
        public OptionList Options { get; set; }

    }
}