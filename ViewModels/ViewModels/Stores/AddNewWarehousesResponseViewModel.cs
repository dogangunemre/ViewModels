using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class AddNewWarehousesResponseViewModel:ResponseViewModel<AddNewWarehousesRequestData,AddNewWarehousesResponseData>
    {
        public AddNewWarehousesResponseViewModel() : base()
        {

        }
        public AddNewWarehousesResponseViewModel(AddNewWarehousesRequestData RequestData):base(RequestData)
        {
            
        }
    }
}