using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewCategoryRequestData:IRequestData
    {
        public string PackageID { get; set; }
       public ProductCategoryList ProductCategories { get; set; }
    }
}