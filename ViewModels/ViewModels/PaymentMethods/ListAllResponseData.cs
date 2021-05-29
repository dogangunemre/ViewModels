﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.PaymentMethods;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentMethods
{
    public class ListAllResponseData:IResponseData
    {
        public PaymentMethodList PaymentMethods { get; set; }

    }
}