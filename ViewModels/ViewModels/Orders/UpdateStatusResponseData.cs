using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Orders;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class UpdateStatusResponseData:IResponseData
    {
        public OrderBasic Basic { get; set; }
    }
}