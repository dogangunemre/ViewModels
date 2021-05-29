using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewFeedbacksRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public FeedbackList Feedbacks { get; set; }
    }
}