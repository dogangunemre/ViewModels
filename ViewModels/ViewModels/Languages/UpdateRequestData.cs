﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Languages
{
    public class UpdateRequestData:IRequestData
    {
        public LanguageBasic Language { get; set; }
    }
}