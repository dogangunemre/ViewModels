using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts
{
    public class GetRequestData:IRequestData
    {
        public string BankAccountID { get; set; }

    }
}