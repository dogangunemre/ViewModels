using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderStatuses
{
    public class IsExistRequestData:IRequestData
    {
        public string OrderStatusID { get; set; }

    }
}