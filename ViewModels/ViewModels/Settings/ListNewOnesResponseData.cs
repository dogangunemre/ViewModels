using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Settings;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
{
    public class ListNewOnesResponseData : IResponseData
    {
        public OperationItemList<SettingBasic> Settings { get; set; }

    }
}