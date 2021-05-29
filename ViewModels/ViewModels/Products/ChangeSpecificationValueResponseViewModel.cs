using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeSpecificationValueResponseViewModel : ResponseViewModel<ChangeSpecificationValueRequestData, ChangeSpecificationValueResponseData>
    {
        public ChangeSpecificationValueResponseViewModel() : base()
        {

        }
        public ChangeSpecificationValueResponseViewModel(ChangeSpecificationValueRequestData RequestData) : base(RequestData)
        {

        }
    }
}