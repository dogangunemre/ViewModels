using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Specifications
{
    public class AddNewRequestData:IRequestData
    {
        public SpecificationBasic Specification { get; set; }
    }
}