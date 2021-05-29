using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class DeleteRuleConstraintRequestData:IRequestData
    {
        public string DiscountID { get; set; }
        public string ConstraintID { get; set; }
    }
}