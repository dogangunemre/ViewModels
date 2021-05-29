using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteTaxResponseViewModel:ResponseViewModel<DeleteTaxRequestData,DeleteTaxResponseData>
    {
        public DeleteTaxResponseViewModel()
        {
            
        }

        public DeleteTaxResponseViewModel(DeleteTaxRequestData RequestData):base(RequestData)
        {
            
        }
    }
}