using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class DeleteRuleRequestData:IRequestData
    {
        public string RuleID { get; set; }
    }
}