using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Invoices
{
    public class AddNewResponseData:IResponseData
    {
        public InvoiceBasic Invoice { get; set; }

    }
}