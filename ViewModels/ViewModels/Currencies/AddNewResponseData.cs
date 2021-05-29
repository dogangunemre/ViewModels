using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Currencies
{
    public class AddNewResponseData : IResponseData
    {
        public CurrencyBasic Currency { get; set; }
    }
}