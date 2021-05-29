using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class DeleteItemRequestData:IRequestData
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
    }
}