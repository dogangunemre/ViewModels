﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeAttributeValueResponseData : IResponseData
    {
        public AttributeBasic Attribute { get; set; }

    }
}