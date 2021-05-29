using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class ChangeAttributeValueResponseViewModel:ResponseViewModel<ChangeAttributeValueRequestData,ChangeAttributeValueResponseData>
    {
        public ChangeAttributeValueResponseViewModel():base()
        {
            
        }

        public ChangeAttributeValueResponseViewModel(ChangeAttributeValueRequestData RequestData):base(RequestData)
        {
            
        }

    }
}