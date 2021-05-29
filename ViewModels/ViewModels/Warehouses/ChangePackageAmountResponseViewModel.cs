using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
   
    public class ChangePackageAmountResponseViewModel:ResponseViewModel<ChangePackageAmountRequestData,ChangePackageAmountResponseData>
    {
        public ChangePackageAmountResponseViewModel() : base()
        {

        }
        public ChangePackageAmountResponseViewModel(ChangePackageAmountRequestData RequestData):base(RequestData)
        {
            
        }

    }
}