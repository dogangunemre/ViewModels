using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{

    public class AddNewAddressResponseViewModel:ResponseViewModel<AddNewAddressRequestData,AddNewAddressResponseData>
    {
        public AddNewAddressResponseViewModel() : base()
        {

        }
        public AddNewAddressResponseViewModel(AddNewAddressRequestData RequestData) : base(RequestData)
        {

        }
    }
}