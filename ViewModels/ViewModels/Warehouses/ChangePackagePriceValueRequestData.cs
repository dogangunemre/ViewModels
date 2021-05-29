using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class ChangePackagePriceValueRequestData:IRequestData
    {
        public PriceBasic Price { get; set; }
        public string PackageID { get; set; }
    }
}