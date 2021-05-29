using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class ChangeManufacturerRequestData:IRequestData
    {
        public ManufacturerBasic Manufacturer { get; set; }

    }
}