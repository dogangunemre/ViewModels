using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class AddNewPackageResponseViewModel:ResponseViewModel<AddNewPackageRequestData,AddNewPackageResponseData>
    {
        public AddNewPackageResponseViewModel() : base()
        {

        }
        public AddNewPackageResponseViewModel(AddNewPackageRequestData RequestData):base(RequestData)
        {
            
        }
    }
}