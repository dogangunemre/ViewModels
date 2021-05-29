using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteTaxRequestData : IRequestData
    {
        public string TaxID { get; set; }

    }
}