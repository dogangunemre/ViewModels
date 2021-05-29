using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteFileRequestData:IRequestData
    {
        public string FileID { get; set; }

    }
}