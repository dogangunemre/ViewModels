using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
 
    public class ChangeProductAmountResponseViewModel:ResponseViewModel<ChangeProductAmountRequestData,ChangeProductAmountResponseData>
    {
        public ChangeProductAmountResponseViewModel() : base()
        {

        }
        public ChangeProductAmountResponseViewModel(ChangeProductAmountRequestData RequestData):base(RequestData)
        {
            
        }

    }
}