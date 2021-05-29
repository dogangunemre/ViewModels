using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteRequestData : IRequestData
    {
        public string PackageID { get; set; }
    }
}