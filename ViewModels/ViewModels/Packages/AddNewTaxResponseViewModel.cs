using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewTaxResponseViewModel:ResponseViewModel<AddNewTaxRequestData,AddNewTaxResponseData>
    {
        public AddNewTaxResponseViewModel():base()
        {
            
        }

        public AddNewTaxResponseViewModel(AddNewTaxRequestData RequestData):base(RequestData)
        {
            
        }

    }
}