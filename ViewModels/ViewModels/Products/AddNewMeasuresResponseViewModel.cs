using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewMeasuresResponseViewModel : ResponseViewModel<AddNewMeasuresRequestData, AddNewMeasuresResponseData>
    {
        public AddNewMeasuresResponseViewModel() : base()
        {

        }
        public AddNewMeasuresResponseViewModel(AddNewMeasuresRequestData RequestData) : base(RequestData)
        {

        }
    }
}