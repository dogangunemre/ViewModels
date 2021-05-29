using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Options
{
    public class UpdateRequestData : IRequestData
    {
        public OptionBasic Option { get; set; }
    }
}