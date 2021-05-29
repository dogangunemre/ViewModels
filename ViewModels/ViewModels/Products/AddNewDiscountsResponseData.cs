using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewDiscountsResponseData : IResponseData
    {
        public DiscountList Discounts { get; set; }
    }
}