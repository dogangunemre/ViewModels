﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Cargos
{
    public class UpdateRequestData:IRequestData
    {
        public CargoBasic Cargo { get; set; }
    }
}