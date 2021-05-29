using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class AddNewDiscountRequestData:IRequestData
    {
        public string CustomerID { get; set; }
        public DiscountList Discounts { get; set; }
    }
}