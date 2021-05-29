using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class AddNewRuleResponseViewModel
    {
        public AddNewRuleRequestData RequestData { get; set; }
        public AddNewRuleResponseData ResponseData { get; set; }

    }
}