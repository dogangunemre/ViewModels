using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeBrandsResponseViewModel : ResponseViewModel<ChangeBrandsRequestData, ChangeBrandsResponseData>
    {
        public ChangeBrandsResponseViewModel() : base()
        {

        }
        public ChangeBrandsResponseViewModel(ChangeBrandsRequestData RequestData) : base(RequestData)
        {

        }
    }
}