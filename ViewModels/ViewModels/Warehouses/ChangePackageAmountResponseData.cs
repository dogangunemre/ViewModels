using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class ChangePackageAmountResponseData:IResponseData
    {
        public string WarehouseID { get; set; }
        public PackageBasic Package { get; set; }
        public int Amount { get; set; }
    }
}