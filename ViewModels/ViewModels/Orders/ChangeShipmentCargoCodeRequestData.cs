using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeShipmentCargoCodeRequestData:IRequestData
    {
        public string OrderID { get; set; }
        public CargoBasic CargoCode { get; set; }
    }
}