using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{

    public class ChangeOptionValueResponseData:IResponseData
    {
        public OptionBasic Option { get; set; }

    }
}