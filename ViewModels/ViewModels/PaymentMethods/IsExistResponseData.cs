﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentMethods
{
    public class IsExistResponseData:IResponseData
    {
        public bool IsExist { get; set; }
    }
}