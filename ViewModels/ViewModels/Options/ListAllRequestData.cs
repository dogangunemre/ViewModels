﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Options
{
    public class ListAllRequestData : IRequestData
    {
        public long Offset { set; get; } = 0;
        public int Limit { set; get; } = 100;
    }
}