using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Warehouses
{
    public class DeleteProductPriceResponseViewModel : ResponseViewModel<DeleteProductPriceRequestData, DeleteProductPriceResponseData>
    {
        public DeleteProductPriceResponseViewModel() : base()
        {

        }
        public DeleteProductPriceResponseViewModel(DeleteProductPriceRequestData RequestData) : base(RequestData)
        {

        }
    }
}