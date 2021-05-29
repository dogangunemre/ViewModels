using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentMethods
{
    public class DeleteRequestData:IRequestData
    {
        public string PaymentMethodID { get; set; }
    }
}