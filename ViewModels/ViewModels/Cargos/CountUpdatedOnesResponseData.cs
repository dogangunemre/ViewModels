using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Cargos
{
    public class CountUpdatedOnesResponseData : IResponseData
    {
        public long Count { get; set; }
    }
}