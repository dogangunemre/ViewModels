using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    public class DeleteRuleResponseViewModel : ResponseViewModel<DeleteRuleRequestData, DeleteRuleResponseData>
    {
        public DeleteRuleResponseViewModel() : base()
        {

        }
        public DeleteRuleResponseViewModel(DeleteRuleRequestData RequestData) : base(RequestData)
        {

        }
    }
}