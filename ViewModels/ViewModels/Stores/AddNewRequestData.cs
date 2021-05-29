using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class AddNewRequestData:IRequestData
    {
        public StoreBasic Store { get; set; }
    }
}