using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewMeasureResponseViewModel:ResponseViewModel<AddNewMeasureRequestData,AddNewMeasureResponseData>
    {
        public AddNewMeasureResponseViewModel():base()
        {
            
        }

        public AddNewMeasureResponseViewModel(AddNewMeasureRequestData RequestData):base(RequestData)
        {
            
        }
    }
}