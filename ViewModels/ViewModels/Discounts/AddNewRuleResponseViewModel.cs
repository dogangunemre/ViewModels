using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Discounts
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