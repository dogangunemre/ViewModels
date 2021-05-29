using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Measures
{
    public class UpdateRequestData : IRequestData
    {
        public MeasureBasic Measure { get; set; }
    }
}