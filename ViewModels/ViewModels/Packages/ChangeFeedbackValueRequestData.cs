using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class ChangeFeedbackValueRequestData:IRequestData
    {
        public FeedbackBasic Feedback { get; set; }

    }
}