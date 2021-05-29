using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class AddNewAddressRequestData:IRequestData
    {
        public string OrderID { get; set; }
        public AddressList Addresses { get; set; }
    }
}