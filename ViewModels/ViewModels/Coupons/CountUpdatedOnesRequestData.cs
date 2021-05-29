using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Coupons
{
    public class CountUpdatedOnesRequestData : IRequestData
    {
        public int OperationDate { get; set; }
    }
}