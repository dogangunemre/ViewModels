using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class DeleteAddressResponseViewModel:ResponseViewModel<DeleteAddressRequestData,DeleteAddressResponseData>
    {
        public DeleteAddressResponseViewModel() : base()
        {

        }
        public DeleteAddressResponseViewModel(DeleteAddressRequestData RequestData):base(RequestData)
        {
            
        }

    }
}