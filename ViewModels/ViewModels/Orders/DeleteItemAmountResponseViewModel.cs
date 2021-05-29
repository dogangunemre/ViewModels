using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class DeleteItemAmountResponseViewModel:ResponseViewModel<DeleteItemAmountRequestData,DeleteItemAmountResponseData>
    {

        public DeleteItemAmountResponseViewModel(DeleteItemAmountRequestData RequestData):base(RequestData)
        {
            
        }
    }
}