using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Variations
{
    public class GetRequestData : IRequestData
    {
        public string VariationID { get; set; }
    }
}