using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeSpecificationValueResponseData : IResponseData
    {
        public SpecificationBasic Specification { get; set; }


    }
}