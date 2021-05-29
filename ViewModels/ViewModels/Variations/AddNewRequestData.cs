using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Variations;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Variations
{
    public class AddNewRequestData:IRequestData
    {
        public VariationBasic Variation { get; set; }
    }
}