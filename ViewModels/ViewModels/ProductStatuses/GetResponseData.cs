using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.ProductStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductStatuses
{
    public class GetResponseData:IResponseData
    {
        public ProductStatusBasic ProductStatus { get; set; }
    }
}