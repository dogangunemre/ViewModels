using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeAttributeValueResponseViewModel : ResponseViewModel<ChangeAttributeValueRequestData, ChangeAttributeValueResponseData>
    {
        public ChangeAttributeValueResponseViewModel() : base()
        {

        }
        public ChangeAttributeValueResponseViewModel(ChangeAttributeValueRequestData RequestData) : base(RequestData)
        {

        }
    }
}