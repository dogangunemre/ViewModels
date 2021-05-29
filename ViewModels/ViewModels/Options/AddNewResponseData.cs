using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Options
{
    public class AddNewResponseData:IResponseData
    {
        public OptionBasic Option { get; set; }

    }
}