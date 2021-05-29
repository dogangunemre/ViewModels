using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewDiscountRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public DiscountList Discounts { get; set; }
    }
}