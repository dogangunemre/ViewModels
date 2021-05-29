using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class DeleteRuleResponseViewModel
    {
        public DeleteRuleRequestData RequestData { get; set; }
        public DeleteResponseData ResponseData { get; set; }
    }
}