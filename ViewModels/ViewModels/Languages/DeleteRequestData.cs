using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Languages
{
    public class DeleteRequestData:IRequestData
    {
        public string LanguageID { get; set; }
    }
}