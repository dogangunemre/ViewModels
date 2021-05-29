using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Currencies
{
    public class AddNewRequestData : IRequestData
    {
        public CurrencyBasic Currency { get; set; }
        public string RegionID { get; set; }
    }
}