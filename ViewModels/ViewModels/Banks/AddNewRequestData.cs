using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Banks
{
    public class AddNewRequestData : IRequestData
    {
        public BankBasic Bank { get; set; }
    }
}