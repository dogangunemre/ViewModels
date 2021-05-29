using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class ChangeRuleConstraintRequestData : IRequestData
    {
        public string Constraint { get; set; }
        public string PromotionID { get; set; }

    }
}