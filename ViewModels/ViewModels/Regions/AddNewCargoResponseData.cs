using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class AddNewCargoResponseData : IResponseData
    {
        public CargoList Cargos { get; set; }

    }
}