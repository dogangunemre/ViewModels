using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{ 
    public class AddNewDiscountResponseViewModel:ResponseViewModel<AddNewDiscountRequestData,AddNewDiscountResponseData>
    {
        public AddNewDiscountResponseViewModel() : base()
        {

        }
        public AddNewDiscountResponseViewModel(AddNewDiscountRequestData RequestData) : base(RequestData)
        {

        }
    }
}