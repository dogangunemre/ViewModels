using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
{
    public class DeleteRequestData : IRequestData
    {
        public string SettingID { get; set; }
    }
}