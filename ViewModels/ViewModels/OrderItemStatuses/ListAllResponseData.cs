using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderItemStatuses
{
    public class ListAllResponseData:IResponseData
    {
        public OrderItemStatusList OrderItemStatuses { get; set; }
    }
}