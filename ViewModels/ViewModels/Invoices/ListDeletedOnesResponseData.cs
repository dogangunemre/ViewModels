using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Invoices
{
    public class ListDeletedOnesResponseData : IResponseData
    {
        public OperationItemList<InvoiceBasic> Invoices { get; set; }
    }
}