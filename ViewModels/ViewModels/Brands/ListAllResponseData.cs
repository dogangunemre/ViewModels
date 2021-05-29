using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Brands
{
    public class ListAllResponseData:IResponseData
    {
        public BrandList Brands { get; set; }

    }
}