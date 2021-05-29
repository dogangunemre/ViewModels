using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Promotions;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class ListAllResponseData : IResponseData
    {
        public PromotionList Promotions { get; set; }
    }
}