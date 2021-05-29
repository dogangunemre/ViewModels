using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ListDeletedOnesResponseData : IResponseData
    {
        public OperationItemList<ProductBasic> Products { get; set; }

    }
}