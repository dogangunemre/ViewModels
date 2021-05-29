using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
{
    public class DeleteRuleConstraintResponseViewModel:ResponseViewModel<DeleteRuleConstraintRequestData,DeleteRuleConstraintResponseData>
    {

        public DeleteRuleConstraintResponseViewModel():base()
        {
            
        }

        public DeleteRuleConstraintResponseViewModel(DeleteRuleConstraintRequestData RequestData):base(RequestData)
        {
            
        }
    }
}