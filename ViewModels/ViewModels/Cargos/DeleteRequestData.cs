﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Cargos
{
    public class DeleteRequestData:IRequestData
    {
        public string CargoID { get; set; }
    }
}