using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class DeleteRuleRequestViewModel
    {
        public DeleteRuleRequestData RequestData { get; set; }
    }
}