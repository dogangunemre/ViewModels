using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewFeedbacksResponseData : IResponseData
    {
        public FeedbackList Feedbacks { get; set; }
        public ProductBasic Product { get; set; }
    }
}