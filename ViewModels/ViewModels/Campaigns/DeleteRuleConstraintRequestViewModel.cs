using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class DeleteRuleConstraintRequestViewModel
    {
        public DeleteRuleConstraintRequestData RequestData { get; set; }
    }
}