using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteDiscountResponseViewModel:ResponseViewModel<DeleteDiscountRequestData,DeleteDiscountResponseData>
    {

        public DeleteDiscountResponseViewModel():base()
        {
            
        }

        public DeleteDiscountResponseViewModel(DeleteDiscountRequestData RequestData):base(RequestData)
        {
            
        }
    }
}