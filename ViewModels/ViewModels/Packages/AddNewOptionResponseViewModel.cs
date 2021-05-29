using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewOptionResponseViewModel:ResponseViewModel<AddNewOptionRequestData,AddNewOptionResponseData>
    {

        public AddNewOptionResponseViewModel():base()
        {
            
        }

        public AddNewOptionResponseViewModel(AddNewOptionRequestData RequestData):base(RequestData)
        {
            
        }

    }
}