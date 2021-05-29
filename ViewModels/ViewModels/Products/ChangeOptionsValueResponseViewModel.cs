using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeOptionsValueResponseViewModel : ResponseViewModel<ChangeAttributeValueRequestData, ChangeAttributeValueResponseData>
    {
        public ChangeOptionsValueResponseViewModel() : base()
        {

        }
        public ChangeOptionsValueResponseViewModel(ChangeAttributeValueRequestData RequestData) : base(RequestData)
        {

        }
    }
}