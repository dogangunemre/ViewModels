using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.CargoStatuses;
using Ohtap.ECommerce.Domain.Models.Objects.ProductStatuses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductStatuses
{
    public class ListAllResponseData:IResponseData
    {
        public ProductStatusList ProductStatuses { get; set; }
    }
}