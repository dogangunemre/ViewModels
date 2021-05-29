using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Brands
{
    public class ListNewOnesResponseData:IResponseData
    {
        public OperationItemList<BrandBasic> Brands { get; set; }

    }
}