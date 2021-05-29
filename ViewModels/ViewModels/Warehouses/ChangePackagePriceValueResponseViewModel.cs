using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{

    public class ChangePackagePriceValueResponseViewModel:ResponseViewModel<ChangePackagePriceValueRequestData,ChangePackagePriceValueResponseData>
    {
        public ChangePackagePriceValueResponseViewModel() : base()
        {

        }
        public ChangePackagePriceValueResponseViewModel(ChangePackagePriceValueRequestData RequestData):base(RequestData)
        {
            
        }

    }
}