using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class UpdateRequestData : IRequestData
    {
        public ProductBasic Product { get; set; }
    }
}