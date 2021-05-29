using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class AddNewAddressRequestData:IRequestData
    {
        public string CustomerID { get; set; }
        public AddressList Addresses { get; set; }
    }
}