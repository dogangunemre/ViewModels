using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class DeleteRuleConstraintResponseViewModel
    {
        public DeleteRuleConstraintRequestData RequestData { get; set; }
        public DeleteRuleConstraintResponseData ResponseData { get; set; }

    }
}