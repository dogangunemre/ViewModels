using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.CargoStatuses
{
    public class GetRequestData:IRequestData
    {
        public string CargoStatusID { get; set; }
    }
}