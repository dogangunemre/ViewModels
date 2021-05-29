using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeDiscountValueResponseViewModel : ResponseViewModel<ChangeDiscountValueRequestData, ChangeDiscountValueResponseData>
    {
        public ChangeDiscountValueResponseViewModel() : base()
        {

        }
        public ChangeDiscountValueResponseViewModel(ChangeDiscountValueRequestData RequestData) : base(RequestData)
        {

        }
    }
}