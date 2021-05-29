using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class DeletePackageResponseViewModel : ResponseViewModel<DeletePackageRequestData, DeletePackageResponseData>
    {
        public DeletePackageResponseViewModel() : base()
        {

        }
        public DeletePackageResponseViewModel(DeletePackageRequestData RequestData) : base(RequestData)
        {

        }
    }
}