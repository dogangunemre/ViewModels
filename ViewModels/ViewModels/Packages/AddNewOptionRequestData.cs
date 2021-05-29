using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewOptionRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public OptionList Options { get; set; }
    }
}