using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class ListNewOnesResponseData : IResponseData
    {
        public OperationItemList<RegionBasic> Regions { get; set; }

    }
}