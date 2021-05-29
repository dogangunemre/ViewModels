using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderItemStatuses
{
    public class DeleteRequestData:IRequestData
    {
        public string OrderItemStatusID { get; set; }
    }
}