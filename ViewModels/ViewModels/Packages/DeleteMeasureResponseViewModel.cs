using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteMeasureResponseViewModel:ResponseViewModel<DeleteMeasureRequestData,DeleteMeasureResponseData>
    {
        public DeleteMeasureResponseViewModel():base()
        {
            
        }

        public DeleteMeasureResponseViewModel(DeleteMeasureRequestData RequestData):base(RequestData)
        {
            
        }
    }
}