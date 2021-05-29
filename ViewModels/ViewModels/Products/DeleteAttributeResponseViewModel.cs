using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteAttributeResponseViewModel : ResponseViewModel<DeleteAttributeRequestData, DeleteAttributeResponseData>
    {
        public DeleteAttributeResponseViewModel() : base()
        {

        }
        public DeleteAttributeResponseViewModel(DeleteAttributeRequestData RequestData) : base(RequestData)
        {

        }
    
        
    }
}