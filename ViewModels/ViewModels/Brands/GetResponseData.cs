using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Brands
{
    public class GetResponseData:IResponseData
    {
        public BrandBasic Brand { get; set; }
    }
}