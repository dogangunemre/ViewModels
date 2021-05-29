using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Promotions
{
    [DataContract]
    public class DeleteRuleRequestViewModel : RequestViewModel<DeleteRuleRequestData>
    {
    }
}