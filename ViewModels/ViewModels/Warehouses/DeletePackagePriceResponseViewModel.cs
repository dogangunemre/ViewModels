using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class DeletePackagePriceResponseViewModel : ResponseViewModel<DeletePackagePriceRequestData, DeletePackagePriceResponseData>
    {
        public DeletePackagePriceResponseViewModel() : base()
        {

        }
        public DeletePackagePriceResponseViewModel(DeletePackagePriceRequestData RequestData) : base(RequestData)
        {

        }
    }
}