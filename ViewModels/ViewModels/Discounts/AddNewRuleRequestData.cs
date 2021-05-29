using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class AddNewRuleRequestData:IRequestData
    {
        public string DiscountID { get; set; }
        public string Rules { get; set; }
    }
}