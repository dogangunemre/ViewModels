using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class ChangeProductAmountRequestData:IRequestData
    {
        public string WarehouseID { get; set; }
        public ProductBasic product { get; set; }
        public int Amount { get; set; }
    }
}