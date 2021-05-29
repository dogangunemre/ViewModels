using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewTaxesRequestData : IRequestData
    {
        public TaxList Taxes { get; set; }
    }
}