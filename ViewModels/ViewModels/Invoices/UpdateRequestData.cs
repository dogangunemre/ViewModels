using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Invoices
{
    public class UpdateRequestData : IRequestData
    {
        public InvoiceBasic Invoice { get; set; }
    }
}