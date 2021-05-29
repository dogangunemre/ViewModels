using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Currencies
{
    public class ListDeletedOnesResponseData : IResponseData
    {
        public OperationItemList<CurrencyBasic> Currencies { get; set; }
    }
}