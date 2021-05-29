using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentMethods
{
    public class IsExistRequestData:IRequestData
    {
        public string PaymentMethodID { get; set; }



    }
}