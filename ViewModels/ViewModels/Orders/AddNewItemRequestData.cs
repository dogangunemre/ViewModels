using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class AddNewItemRequestData:IRequestData
    {
        public string OrderID { get; set; }
        public ProductList Items { get; set; }
    }
}