using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class DeleteDiscountRequestData:IRequestData
    {
        public string CustomerID { get; set; }
        public string DiscountID { get; set; }
    }
}