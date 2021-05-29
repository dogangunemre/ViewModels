using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewSpecificationsRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public SpecificationList Specifications { get; set; }
    }
}