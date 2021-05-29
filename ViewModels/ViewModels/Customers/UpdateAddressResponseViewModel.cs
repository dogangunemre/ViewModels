using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class UpdateAddressResponseViewModel:ResponseViewModel<UpdateAddressRequestData,UpdateAddressResponseData>
    {
        public UpdateAddressResponseViewModel() : base()
        {

        }
        public UpdateAddressResponseViewModel(UpdateAddressRequestData RequestData):base(RequestData)
        {
            
        }
    }
}