using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class AddNewRuleResponseViewModel : ResponseViewModel<AddNewRuleRequestData, AddNewRuleResponseData>
    {
        public AddNewRuleResponseViewModel() : base()
        {

        }
        public AddNewRuleResponseViewModel(AddNewRuleRequestData RequestData) : base(RequestData)
        {

        }
    }
}