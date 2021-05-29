using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class AddNewProductPriceResponseViewModel:ResponseViewModel<AddNewProductPriceRequestData,AddNewProductPriceResponseData>
    {
        public AddNewProductPriceResponseViewModel() : base()
        {

        }
        public AddNewProductPriceResponseViewModel(AddNewProductPriceRequestData RequestData):base(RequestData)
        {
            
        }

    }
}