using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class DeleteItemResponseViewModel:ResponseViewModel<DeleteItemRequestData,DeleteItemResponseData>
    {
        public DeleteItemResponseViewModel():base()
        {
            
        }

        public DeleteItemResponseViewModel(DeleteItemRequestData RequestData):base(RequestData)
        {
            
        }
    }
}