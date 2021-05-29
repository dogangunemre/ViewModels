using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class UpdateRequestData : IRequestData
    {
        public StoreBasic Store { get; set; }
    }
}