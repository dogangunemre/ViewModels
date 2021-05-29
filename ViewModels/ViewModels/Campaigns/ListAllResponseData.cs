using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    public class ListAllResponseData:IResponseData
    {
        public CampaignList Campaigns { get; set; }

    }
}