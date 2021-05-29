using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Settings;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Adapters
{
    public class GetConfigResponseData:IResponseData
    {
        public SettingList Config { get; set; }

    }
}