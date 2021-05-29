using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class ChangePackageAmountRequestData:IRequestData
    {
        public int Amount { get; set; }
    }
}