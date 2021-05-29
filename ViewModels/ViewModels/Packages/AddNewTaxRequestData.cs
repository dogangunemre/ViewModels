using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewTaxRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public TaxList Taxes { get; set; }
    }
}