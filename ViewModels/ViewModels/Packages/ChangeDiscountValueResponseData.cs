using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class ChangeDiscountValueResponseData:IResponseData
    {
        public DiscountBasic Discount { get; set; }

    }
}