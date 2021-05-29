using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteDiscountResponseViewModel : ResponseViewModel<DeleteDiscountRequestData, DeleteDiscountResponseData>
    {
        public DeleteDiscountResponseViewModel() : base()
        {

        }
        public DeleteDiscountResponseViewModel(DeleteDiscountRequestData RequestData) : base(RequestData)
        {

        }

    }
}