using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Languages
{
    public class CountDeletedOnesResponseData : IResponseData
    {
        public long Count { get; set; }
    }
}