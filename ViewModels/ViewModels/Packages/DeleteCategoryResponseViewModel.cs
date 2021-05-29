using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteCategoryResponseViewModel:ResponseViewModel<DeleteCategoryRequestData,DeleteCategoryResponseData>
    {

        public DeleteCategoryResponseViewModel():base()
        {
            
        }

        public DeleteCategoryResponseViewModel(DeleteCategoryRequestData RequestData):base(RequestData)
        {
            
        }
    }
}