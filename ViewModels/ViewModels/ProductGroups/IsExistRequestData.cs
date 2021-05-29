using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductGroups
{
    public class IsExistRequestData:IRequestData
    {
        public string ProductGroupID { get; set; }

    }
}