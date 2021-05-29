using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class AddNewWarehousesResponseData:IResponseData
    {
        public WarehouseList Warehouses { get; set; }

    }
}