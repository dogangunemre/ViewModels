using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeItemAmountResponseData:IResponseData
    {
        public OrderItemBasic OrderItem { get; set; }
    }
}