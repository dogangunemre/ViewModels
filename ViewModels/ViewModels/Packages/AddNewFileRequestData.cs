using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewFileRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public FileList Files { get; set; }
    }
}