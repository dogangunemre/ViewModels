using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeShipmentStatusResponseViewModel:ResponseViewModel<ChangeShipmentStatusRequestData,ChangeShipmentStatusResponseData>
    {

        public ChangeShipmentStatusResponseViewModel():base()
        {
            
        }

        public ChangeShipmentStatusResponseViewModel(ChangeShipmentStatusRequestData RequestData):base(RequestData)
        {
            
        }
    }
}