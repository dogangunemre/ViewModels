using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class AddNewItemResponseData:IResponseData
    {
        public ProductList Items { get; set; }

    }
}