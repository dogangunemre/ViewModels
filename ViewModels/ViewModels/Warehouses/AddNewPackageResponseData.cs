using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class AddNewPackageResponseData:IResponseData
    {
        public PackageList Packages { get; set; }
        public string WarehouseID { get; set; }
    }
}