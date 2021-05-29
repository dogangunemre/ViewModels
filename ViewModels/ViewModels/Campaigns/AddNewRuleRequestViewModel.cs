using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class AddNewRuleRequestViewModel
    {
        public AddNewRuleRequestData RequestData { get; set; }
    }
}