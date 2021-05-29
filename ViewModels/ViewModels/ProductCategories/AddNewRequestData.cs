using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductCategories
{
    public class AddNewRequestData:IRequestData
    {
        public ProductCategoryBasic ProductCategory { get; set; }
    }
}