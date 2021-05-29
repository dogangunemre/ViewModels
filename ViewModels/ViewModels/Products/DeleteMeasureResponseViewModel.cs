using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteMeasureResponseViewModel : ResponseViewModel<DeleteMeasureRequestData, DeleteMeasureResponseData>
    {
        public DeleteMeasureResponseViewModel() : base()
        {

        }
        public DeleteMeasureResponseViewModel(DeleteMeasureRequestData RequestData) : base(RequestData)
        {

        }
    }
}