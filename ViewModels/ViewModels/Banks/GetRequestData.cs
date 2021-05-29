using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Banks
{
    public class GetRequestData:IRequestData
    {
        public string BankID { get; set; }

    }
}