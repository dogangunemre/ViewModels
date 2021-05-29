using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentStatuses
{
    public class IsExistRequestData:IRequestData
    {
        public string PaymentStatusID { get; set; }

    }
}