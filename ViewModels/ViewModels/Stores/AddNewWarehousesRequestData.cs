using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class AddNewWarehousesRequestData:IRequestData
    {
        public string StoreID { get; set; }
        public WarehouseList Warehouses { get; set; }
        
    }
}