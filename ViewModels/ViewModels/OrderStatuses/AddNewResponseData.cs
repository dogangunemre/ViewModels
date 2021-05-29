using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses;
using Ohtap.ECommerce.Domain.Models.Objects.OrderStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderStatuses
{
    public class AddNewResponseData:IResponseData
    {
        public OrderStatusBasic OrderStatus { get; set; }

    }
}