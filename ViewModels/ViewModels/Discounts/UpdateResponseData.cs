using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class UpdateResponseData : IResponseData
    {
        public DiscountBasic Discount { get; set; }
    }
}