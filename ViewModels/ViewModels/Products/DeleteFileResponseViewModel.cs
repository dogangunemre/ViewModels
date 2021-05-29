using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteFileResponseViewModel : ResponseViewModel<DeleteFileRequestData, DeleteFileResponseData>
    {
        public DeleteFileResponseViewModel() : base()
        {

        }
        public DeleteFileResponseViewModel(DeleteFileRequestData RequestData) : base(RequestData)
        {

        }
    }
}