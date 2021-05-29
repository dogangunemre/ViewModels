using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class ListAllResponseData : IResponseData
    {
        public RegionList Regions { get; set; }
    }
}