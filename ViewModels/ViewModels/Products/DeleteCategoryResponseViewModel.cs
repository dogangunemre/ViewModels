using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteCategoryResponseViewModel : ResponseViewModel<DeleteCategoryRequestData, DeleteCategoryResponseData>
    {
        public DeleteCategoryResponseViewModel() : base()
        {

        }
        public DeleteCategoryResponseViewModel(DeleteCategoryRequestData RequestData) : base(RequestData)
        {

        }
    }
}