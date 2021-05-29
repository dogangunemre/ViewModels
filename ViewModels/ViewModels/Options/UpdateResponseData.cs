using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Options
{
    public class UpdateResponseData : IResponseData
    {
        public OptionBasic Option { get; set; }
    }
}