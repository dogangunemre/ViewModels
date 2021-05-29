using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class DeleteRuleConstraintRequestData : IRequestData
    {
        public string RuleConstraintID { get; set; }

    }
}