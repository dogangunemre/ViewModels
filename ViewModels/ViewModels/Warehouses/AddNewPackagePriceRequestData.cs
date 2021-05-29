using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class AddNewPackagePriceRequestData:IRequestData
    {
        public string ProductID { get; set; }
        public PriceBasic Price { get; set; }
    }
}