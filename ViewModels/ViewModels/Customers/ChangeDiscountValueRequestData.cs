using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class ChangeDiscountValueRequestData:IRequestData
    {
        public CustomerBasic Customer { get; set; }
        public DiscountBasic Discount { get; set; }
    }
}