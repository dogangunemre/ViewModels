using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Suppliers;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Suppliers
{
    public class UpdateRequestData : IRequestData
    {
        public SupplierBasic Supplier { get; set; }
    }
}