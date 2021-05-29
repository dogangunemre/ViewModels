using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewCategoryResponseViewModel:ResponseViewModel<AddNewCategoryRequestData,AddNewCategoryResponseData>
    {

        public AddNewCategoryResponseViewModel():base()
        {
            
        }

        public AddNewCategoryResponseViewModel(AddNewCategoryRequestData RequestData):base(RequestData)
        {
            
        }
    }
}