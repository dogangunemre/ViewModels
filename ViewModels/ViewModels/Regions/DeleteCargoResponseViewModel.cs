using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class DeleteCargoResponseViewModel : ResponseViewModel<DeleteCargoRequestData, DeleteCargoResponseData>
    {
        public DeleteCargoResponseViewModel() : base()
        {

        }
        public DeleteCargoResponseViewModel(DeleteCargoRequestData RequestData) : base(RequestData)
        {

        }
    }
}