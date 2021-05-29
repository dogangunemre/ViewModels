using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewFileResponseData:IResponseData
    {
        public FileList Files { get; set; }

    }
}