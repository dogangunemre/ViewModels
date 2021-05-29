using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class AddNewProductRequestData:IRequestData
    {
        public ProductList Products { get; set; }
        public string WarehouseID { get; set; }
    }
}