using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
{
    public class CountNewOnesRequestData : IRequestData
    {
        public int OperationDate { get; set; }
    }
}