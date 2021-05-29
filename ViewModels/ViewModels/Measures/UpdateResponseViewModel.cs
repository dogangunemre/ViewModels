using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Measures
{
    public class UpdateResponseViewModel : ResponseViewModel<UpdateRequestData,UpdateResponseData>
    {
        public UpdateResponseViewModel():base()
        {
            
        }

        public UpdateResponseViewModel(UpdateRequestData RequestData):base(RequestData)
        {
            
        }
    }
}