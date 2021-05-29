using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class DeleteRuleConstraintResponseViewModel : ResponseViewModel<DeleteRuleConstraintRequestData, DeleteRuleConstraintResponseData>
    {
        public DeleteRuleConstraintResponseViewModel() : base()
        {

        }
        public DeleteRuleConstraintResponseViewModel(DeleteRuleConstraintRequestData RequestData) : base(RequestData)
        {

        }


    }
}