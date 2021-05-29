using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Options
{
    public class AddNewRequestData:IRequestData
    {
        public OptionBasic Option { get; set; }
    }
}