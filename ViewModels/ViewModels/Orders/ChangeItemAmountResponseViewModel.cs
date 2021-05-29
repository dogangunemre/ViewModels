using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeItemAmountResponseViewModel:ResponseViewModel<ChangeItemAmountRequestData,ChangeItemAmountResponseData>
    {
        public ChangeItemAmountResponseViewModel():base()
        {
            
        }

        public ChangeItemAmountResponseViewModel(ChangeItemAmountRequestData RequestData):base(RequestData)
        {
            
        }

    }
}