using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.PaymentStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentStatuses
{
    public class AddNewResponseData:IResponseData
    {
        public PaymentStatusBasic PaymentStatus { get; set; }

    }
}