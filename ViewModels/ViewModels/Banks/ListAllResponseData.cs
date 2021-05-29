using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Banks
{
    public class ListAllResponseData:IResponseData
    {
        public BankList Banks { get; set; }

    }
}