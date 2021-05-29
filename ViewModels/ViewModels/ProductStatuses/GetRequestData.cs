using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductStatuses
{
    public class GetRequestData:IRequestData
    {
        public string ProductStatusID { get; set; }
    }
}