using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class AddNewRuleRequestData : IRequestData
    {
        public string Rules { get; set; }
        public string PromotionID { get; set; }

    }
}