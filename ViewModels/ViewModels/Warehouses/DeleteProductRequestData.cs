﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class DeleteProductRequestData : IRequestData
    {
        public string ProductID { get; set; }
        public string WarehouseID { get; set; }
    }
}