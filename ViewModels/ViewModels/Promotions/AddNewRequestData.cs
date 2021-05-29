using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Promotions;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class AddNewRequestData : IRequestData
    {
        public PromotionBasic Promotion { get; set; }

    }
}