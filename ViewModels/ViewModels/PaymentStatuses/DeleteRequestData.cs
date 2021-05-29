using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentStatuses
{
    public class DeleteRequestData:IRequestData
    {
        public string PaymentStatusID { get; set; }
    }
}