using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class AddNewRuleConstraintRequestData:IRequestData
    {
        public string RuleID { get; set; }
        public string Constraint { get; set; }
    }
}