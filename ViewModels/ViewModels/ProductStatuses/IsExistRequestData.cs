using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductStatuses
{
    public class IsExistRequestData:IRequestData
    {
        public string ProductStatusID { get; set; }
    }
}