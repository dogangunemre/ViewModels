using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class ChangeOptionValueResponseViewModel:ResponseViewModel<ChangeOptionValueRequestData,ChangeOptionValueResponseData>
    {

        public ChangeOptionValueResponseViewModel():base()
        {
            
        }

        public ChangeOptionValueResponseViewModel(ChangeOptionValueRequestData RequestData):base(RequestData)
        {
            
        }
    }
}