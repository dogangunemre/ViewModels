using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class DeleteCargoRequestData : IRequestData
    {
        public string RegionID { get; set; }
        public string CargoID { get; set; }
    }
}