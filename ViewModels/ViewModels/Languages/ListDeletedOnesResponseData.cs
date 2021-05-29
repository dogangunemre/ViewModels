﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Languages
{
    public class ListDeletedOnesResponseData : IResponseData
    {
        public OperationItemList<LanguageBasic> Languages { get; set; }
    }
}