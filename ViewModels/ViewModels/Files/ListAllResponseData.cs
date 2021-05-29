using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Files
{
    public class ListAllResponseData:IResponseData
    {
        public FileList Files { get; set; }

    }
}