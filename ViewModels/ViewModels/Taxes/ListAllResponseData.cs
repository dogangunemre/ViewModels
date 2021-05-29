using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Taxes
{
    public class ListAllResponseData:IResponseData
    {
        public TaxList Taxes { get; set; }

    }
}