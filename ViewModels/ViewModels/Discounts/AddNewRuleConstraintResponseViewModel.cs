using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class AddNewRuleConstraintResponseViewModel:ResponseViewModel<AddNewRuleConstraintRequestData,AddNewRuleConstraintResponseData>
    {
        public AddNewRuleConstraintResponseViewModel():base()
        {
            
        }

        public AddNewRuleConstraintResponseViewModel(AddNewRuleConstraintRequestData RequestData):base(RequestData)
        {
            
        }
    }
}