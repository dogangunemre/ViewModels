using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
   
    public class AddNewPackagePriceResponseViewModel:ResponseViewModel<AddNewPackagePriceRequestData,AddNewPackagePriceResponseData>
    {
        public AddNewPackagePriceResponseViewModel() : base()
        {

        }
        public AddNewPackagePriceResponseViewModel(AddNewPackagePriceRequestData RequestData):base(RequestData)
        {
            
        }

    }
}