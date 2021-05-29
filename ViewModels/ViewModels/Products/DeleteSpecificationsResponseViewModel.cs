using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteSpecificationsResponseViewModel : ResponseViewModel<DeleteSpecificationRequestData, DeleteSpecificationsResponseData>
    {
        public DeleteSpecificationsResponseViewModel() : base()
        {

        }
        public DeleteSpecificationsResponseViewModel(DeleteSpecificationRequestData RequestData) : base(RequestData)
        {

        }
    }
}