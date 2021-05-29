using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteOptionResponseViewModel : ResponseViewModel<DeleteOptionRequestData, DeleteFeedbackResponseData>
    {
        public DeleteOptionResponseViewModel() : base()
        {

        }
        public DeleteOptionResponseViewModel(DeleteOptionRequestData RequestData) : base(RequestData)
        {

        }
    }
}