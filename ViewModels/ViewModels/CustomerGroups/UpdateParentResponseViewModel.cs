using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.CustomerGroups
{
    public class UpdateParentResponseViewModel:ResponseViewModel<UpdateParentRequestData,UpdateParentResponseData>
    {
        public UpdateParentResponseViewModel() : base()
        {

        }
        public UpdateParentResponseViewModel(UpdateParentRequestData RequestData) : base(RequestData)
        {

        }

    }
}