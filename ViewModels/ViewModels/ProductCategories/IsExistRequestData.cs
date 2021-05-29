using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductCategories
{
    public class IsExistRequestData:IRequestData
    {
        public string ProductCategoryID { get; set; }

    }
}