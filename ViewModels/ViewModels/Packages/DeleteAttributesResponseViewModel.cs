using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteAttributesResponseViewModel:ResponseViewModel<DeleteAttributesRequestData,DeleteAttributesResponseData>
    {
        public DeleteAttributesResponseViewModel():base()
        {
            
        }

        public DeleteAttributesResponseViewModel(DeleteAttributesRequestData RequestData):base(RequestData)
        {
            
        }

    }
}