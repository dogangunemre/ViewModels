using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderStatuses
{
    public class GetRequestData:IRequestData
    {
        public string OrderStatusID { get; set; }
    }
}