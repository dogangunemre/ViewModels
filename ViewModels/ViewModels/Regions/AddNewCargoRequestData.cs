using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class AddNewCargoRequestData : IRequestData
    {
        public string CargoID { get; set; }
        public CargoList Cargos { get; set; }
    }
}