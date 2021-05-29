using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
  
    public class ChangeRuleConstraintResponseViewModel:ResponseViewModel<ChangeRuleConstraintRequestData,ChangeRuleConstraintResponseData>
    {

        public ChangeRuleConstraintResponseViewModel():base()
        {
            
        }

        public ChangeRuleConstraintResponseViewModel(ChangeRuleConstraintRequestData RequestData):base(RequestData)
        {
            
        }
    }
}