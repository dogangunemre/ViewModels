using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class GetResponseData:IResponseData
    {
        public CustomerBasic Customer { get; set; }
    }
}