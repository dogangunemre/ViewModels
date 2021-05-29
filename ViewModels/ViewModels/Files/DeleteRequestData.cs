using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Files
{
    public class DeleteRequestData:IRequestData
    {
        public string FileID { get; set; }
    }
}