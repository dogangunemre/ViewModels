using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses;
using Ohtap.ECommerce.Domain.Models.Objects.OrderStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderStatuses
{
    public class ListAllResponseData:IResponseData
    {
        public OrderStatusList OrderStatuses { get; set; }
    }
}