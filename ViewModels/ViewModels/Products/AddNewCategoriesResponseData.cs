using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewCategoriesResponseData : IResponseData
    {
        public ProductCategoryList Categories { get; set; }

    }
}