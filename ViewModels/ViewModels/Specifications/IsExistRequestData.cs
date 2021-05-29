using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Specifications
{
    public class IsExistRequestData : IRequestData
    {
        public string SpecificationID { get; set; }
    }
}