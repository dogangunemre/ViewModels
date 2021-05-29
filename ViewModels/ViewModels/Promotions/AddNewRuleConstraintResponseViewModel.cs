using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    [DataContract]
    public class AddNewRuleConstraintResponseViewModel : ResponseViewModel<AddNewRuleConstraintRequestData, AddNewRuleConstraintResponseData>
    {
        public AddNewRuleConstraintResponseViewModel() : base()
        {

        }
        public AddNewRuleConstraintResponseViewModel(AddNewRuleConstraintRequestData RequestData) : base(RequestData)
        {

        }
    }
}