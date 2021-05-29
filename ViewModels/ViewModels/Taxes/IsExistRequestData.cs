using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Taxes
{
    public class IsExistRequestData:IRequestData
    {
        public string TaxID { get; set; }

    }
}