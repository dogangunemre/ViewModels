using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class IsExistRequestData : IRequestData
    {
        public string StoreID { get; set; }
    }
}