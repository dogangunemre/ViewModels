using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class DeletePackageRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public string WarehouseID { get; set; }
    }
}