using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers

{
    public class DeleteDiscountResponseViewModel:ResponseViewModel<DeleteDiscountRequestData,DeleteDiscountResponseData>
    {
        public DeleteDiscountResponseViewModel() : base()
        {

        }
        public DeleteDiscountResponseViewModel(DeleteDiscountRequestData RequestData):base(RequestData)
        {
            
        }

    }
}