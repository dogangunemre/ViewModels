using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Promotions;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class ListNewOnesResponseData : IResponseData
    {
        public OperationItemList<PromotionBasic> Promotions { get; set; }

    }
}