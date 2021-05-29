using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteFeedbacksRequestData:IRequestData
    {
        public string FeedbackID { get; set; }

    }
}