using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class AddNewCargoResponseViewModel : ResponseViewModel<AddNewCargoRequestData, AddNewCargoResponseData>
    {
        public AddNewCargoResponseViewModel() : base()
        {

        }
        public AddNewCargoResponseViewModel(AddNewCargoRequestData RequestData) : base(RequestData)
        {

        }
    }
}