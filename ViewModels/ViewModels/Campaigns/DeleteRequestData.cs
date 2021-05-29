using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    public class DeleteRequestData:IRequestData
    {
        public string CampaingID { get; set; }
    }
}