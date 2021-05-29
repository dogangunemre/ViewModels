using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeManufacturersRequestData : IRequestData
    {
        public ManufacturerList Manufacturers{ get; set; }
    }
}