using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class AddNewRuleConstraintRequestViewModel
    {
        public AddNewRuleConstraintRequestData RequestData { get; set; }
    }
}