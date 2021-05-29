using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.Suppliers;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Suppliers
{
    public class ListDeletedOnesResponseData : IResponseData
    {
        public OperationItemList<SupplierBasic> Suppliers { get; set; }
    }
}