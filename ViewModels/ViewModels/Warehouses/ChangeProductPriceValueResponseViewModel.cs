using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{

    public class ChangeProductPriceValueResponseViewModel:ResponseViewModel<ChangeProductPriceValueRequestData,ChangeProductPriceValueResponseData>
    {
        public ChangeProductPriceValueResponseViewModel() : base()
        {

        }

        public ChangeProductPriceValueResponseViewModel(ChangeProductPriceValueRequestData RequestData):base(RequestData)
        {
            
        }
    }
}