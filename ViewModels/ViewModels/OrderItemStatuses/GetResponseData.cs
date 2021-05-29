using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderItemStatuses
{
    public class GetResponseData:IResponseData
    {
        public OrderItemStatusBasic OrderItemStatus { get; set; }
    }
}