using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class ChangeRuleConstraintRequestViewModel
    {
        public ChangeRuleConstraintRequestData RequestData { get; set; }
    }
}