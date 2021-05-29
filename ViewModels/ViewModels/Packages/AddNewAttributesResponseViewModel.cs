using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewAttributesResponseViewModel:ResponseViewModel<AddNewAttributesRequestData,AddNewAttributesResponseData>
    {
        public AddNewAttributesResponseViewModel():base()
        {
            
        }

        public AddNewAttributesResponseViewModel(AddNewAttributesRequestData RequestData):base(RequestData)
        {
            
        }
    }
}