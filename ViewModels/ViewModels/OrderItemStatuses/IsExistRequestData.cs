using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderItemStatuses
{
    public class IsExistRequestData:IRequestData
    {
        public string OrderItemStatusID { get; set; }

    }
}