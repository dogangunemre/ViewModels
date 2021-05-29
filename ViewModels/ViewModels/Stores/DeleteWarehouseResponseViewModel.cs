using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Stores
{
    public class DeleteWarehouseResponseViewModel:ResponseViewModel<DeleteWarehouseRequestData,DeleteWarehouseResponseData>
    {
        public DeleteWarehouseResponseViewModel() : base()
        {

        }
        public DeleteWarehouseResponseViewModel(DeleteWarehouseRequestData RequestData):base(RequestData)
        {
            
        }
    }
}