using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class AddNewRuleConstraintRequestData : IRequestData
    {
        public string RuleConstraints { get; set; }
        public string RuleID { get; set; }

    }
}