using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteTaxRequestData:IRequestData
    {
        public string TaxID { get; set; }

    }
}