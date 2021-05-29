using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Manufacturers
{
    public class UpdateRequestData : IRequestData
    {
        public ManufacturerBasic Manufacturer { get; set; }
    }
}