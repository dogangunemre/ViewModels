using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.ProductGroups;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductGroups
{
    public class AddNewRequestData:IRequestData
    {
        public ProductGroupBasic ProductGroup { get; set; }
    }
}