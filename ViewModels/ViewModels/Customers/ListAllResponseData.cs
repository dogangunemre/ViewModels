using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class ListAllResponseData:IResponseData
    {
        public CustomerList Customers { get; set; }
    }
}