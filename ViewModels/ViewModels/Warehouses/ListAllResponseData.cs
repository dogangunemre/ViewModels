using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class ListAllResponseData : IResponseData
    {
        public WarehouseList Warehouses { get; set; }
    }
}