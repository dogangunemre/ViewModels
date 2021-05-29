using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Currencies
{
    public class CountDeletedOnesRequestData : IRequestData
    {
        public long OperationDate { get; set; } 
        public string RegionID { get; set; }

    }
}