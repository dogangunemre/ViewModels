using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteFileResponseViewModel:ResponseViewModel<DeleteFileRequestData,DeleteFileResponseData>
    {

        public DeleteFileResponseViewModel():base()
        {
            
        }

        public DeleteFileResponseViewModel(DeleteFileRequestData RequestData):base(RequestData)
        {
            
        }
    }
}