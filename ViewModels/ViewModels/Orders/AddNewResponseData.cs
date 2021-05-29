using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Orders;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class AddNewResponseData:IResponseData
    {
        public OrderBasic Order { get; set; }


    }
}