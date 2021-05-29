using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.ProductGroups;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductGroups
{
    public class ListUpdatedOnesResponseData : IResponseData
    {
        public OperationItemList<ProductGroupBasic> ProductGroups { get; set; }

    }
}