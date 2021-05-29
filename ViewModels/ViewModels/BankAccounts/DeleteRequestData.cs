using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts
{
    public class DeleteRequestData:IRequestData
    {
        public string BankAccountID { get; set; }
    }
}