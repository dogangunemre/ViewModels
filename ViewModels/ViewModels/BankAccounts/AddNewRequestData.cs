using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.BankAccounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts
{
    public class AddNewRequestData : IRequestData
    {
        public BankAccountBasic BankAccount { get; set; }
    }
}