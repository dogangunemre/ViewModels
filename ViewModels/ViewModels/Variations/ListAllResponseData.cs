using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Variations;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Variations
{
    public class ListAllResponseData : IResponseData
    {
        public VariationList Variations { get; set; }
    }
}