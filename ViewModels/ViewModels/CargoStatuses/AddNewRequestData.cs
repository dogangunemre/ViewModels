using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.CargoStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.CargoStatuses
{
    public class AddNewRequestData:IRequestData
    {
        public CargoStatusBasic CargoStatus { get; set; }
    }
}