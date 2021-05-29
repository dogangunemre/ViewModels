using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class AddNewItemResponseViewModel:ResponseViewModel<AddNewItemRequestData,AddNewItemResponseData>
    {

        public AddNewItemResponseViewModel():base()
        {
            
        }

        public AddNewItemResponseViewModel(AddNewItemRequestData RequestData):base(RequestData)
        {
            
        }
    }
}