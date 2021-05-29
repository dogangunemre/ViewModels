using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class UpdateResponseData : IResponseData
    {
        public RegionBasic Region { get; set; }

    }
}