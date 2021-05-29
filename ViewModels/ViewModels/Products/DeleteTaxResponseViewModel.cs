using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteTaxResponseViewModel : ResponseViewModel<DeleteTaxRequestData, DeleteTaxResponseData>
    {
        public DeleteTaxResponseViewModel() : base()
        {

        }
        public DeleteTaxResponseViewModel(DeleteTaxRequestData RequestData) : base(RequestData)
        {

        }
    }
}