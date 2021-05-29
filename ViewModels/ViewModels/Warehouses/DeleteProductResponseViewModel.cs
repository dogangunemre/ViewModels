using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class DeleteProductResponseViewModel : ResponseViewModel<DeleteProductRequestData, DeleteProductResponseData>
    {
        public DeleteProductResponseViewModel() : base()
        {

        }
        public DeleteProductResponseViewModel(DeleteProductRequestData RequestData) : base(RequestData)
        {

        }
    }
}