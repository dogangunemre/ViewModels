using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class ChangeRuleConstraintResponseViewModel : ResponseViewModel<ChangeRuleConstraintRequestData, ChangeRuleConstraintResponseData>
    {
        public ChangeRuleConstraintResponseViewModel() : base()
        {

        }
        public ChangeRuleConstraintResponseViewModel(ChangeRuleConstraintRequestData RequestData) : base(RequestData)
        {

        }
    }
}