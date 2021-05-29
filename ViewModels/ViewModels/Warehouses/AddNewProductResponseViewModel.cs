using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{

    public class AddNewProductResponseViewModel:ResponseViewModel<AddNewProductRequestData,AddNewProductResponseData>
    {
        public AddNewProductResponseViewModel() : base()
        {

        }
        public AddNewProductResponseViewModel(AddNewProductRequestData RequestData):base(RequestData)
        {
            
        }

    }
}