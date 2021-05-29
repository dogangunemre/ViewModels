using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class IsExistRequestData : IRequestData
    {
        public string PromotionID { get; set; }
    }
}