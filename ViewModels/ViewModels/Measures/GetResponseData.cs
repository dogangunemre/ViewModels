using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Measures
{
    public class GetResponseData : IResponseData
    {
        public MeasureBasic Measure { get; set; }
    }
}