using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class ChangeSpecificationValueResponseViewModel:ResponseViewModel<ChangeSpecificationValueRequestData,ChangeSpecificationValueResponseData>
    {
        public ChangeSpecificationValueResponseViewModel():base()
        {
            
        }

        public ChangeSpecificationValueResponseViewModel(ChangeSpecificationValueRequestData RequestData):base(RequestData)
        {
            
        }
    }
}