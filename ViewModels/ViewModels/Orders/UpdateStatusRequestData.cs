using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class UpdateStatusRequestData:IRequestData
    {
        public string OrderID { get; set; }
        public string Status { get; set; }
    }
}