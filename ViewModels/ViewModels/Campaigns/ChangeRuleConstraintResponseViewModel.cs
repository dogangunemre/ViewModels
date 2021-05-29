using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class ChangeRuleConstraintResponseViewModel
    {
        public ChangeRuleConstraintRequestData RequestData { get; set; }
        public ChangeRuleConstraintResponseData ResponseData { get; set; }
    }
}