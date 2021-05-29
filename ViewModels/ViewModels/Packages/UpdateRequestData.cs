using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class UpdateRequestData : IRequestData
    {
        public PackageBasic Package { get; set; }
    }
}