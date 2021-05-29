using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Taxes
{
    public class ListUpdatedOnesResponseData : IResponseData
    {
        public OperationItemList<TaxBasic> Taxes { get; set; }

    }
}