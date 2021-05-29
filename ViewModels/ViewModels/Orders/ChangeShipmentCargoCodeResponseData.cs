using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeShipmentCargoCodeResponseData:IResponseData
    {
        public ShippingBasic Shipping { get; set; }
    }
}