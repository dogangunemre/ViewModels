using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Settings;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
{
    public class GetResponseData : IResponseData
    {
        public SettingBasic Setting { get; set; }
    }
}