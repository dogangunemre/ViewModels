using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class UpdateAddressResponseData:IResponseData
    {
        public AddressList Addresses { get; set; }

    }
}