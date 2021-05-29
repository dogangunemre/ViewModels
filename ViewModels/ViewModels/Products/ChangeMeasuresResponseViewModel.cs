using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeMeasuresResponseViewModel : ResponseViewModel<ChangeMeasuresRequestData, ChangeMeasuresResponseData>
    {
        public ChangeMeasuresResponseViewModel() : base()
        {

        }
        public ChangeMeasuresResponseViewModel(ChangeMeasuresRequestData RequestData) : base(RequestData)
        {

        }
    }
}