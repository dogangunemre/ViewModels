using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class ChangeDiscountValueResponseViewModel:ResponseViewModel<ChangeDiscountValueRequestData,ChangeDiscountValueResponseData>
    {
        public ChangeDiscountValueResponseViewModel() : base()
        {

        }
        public ChangeDiscountValueResponseViewModel(ChangeDiscountValueRequestData RequestData):base(RequestData)
        {
            
        }
    }
}