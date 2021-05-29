using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class AddNewDiscountResponseData:IResponseData
    {
        public DiscountList Discounts { get; set; }

    }
}