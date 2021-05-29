using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeShipmentCargoCodeResponseViewModel:ResponseViewModel<ChangeShipmentCargoCodeRequestData,ChangeShipmentCargoCodeResponseData>
    {
        public ChangeShipmentCargoCodeResponseViewModel():base()
        {
            
        }

        public ChangeShipmentCargoCodeResponseViewModel(ChangeShipmentCargoCodeRequestData RequestData):base(RequestData)
        {
            
        }
    }
}