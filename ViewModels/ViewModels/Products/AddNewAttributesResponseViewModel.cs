using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewAttributesResponseViewModel : ResponseViewModel<AddNewAttributesRequestData, AddNewAttributesResponseData>
    {
        public AddNewAttributesResponseViewModel() : base()
        { 

        }
        public AddNewAttributesResponseViewModel(AddNewAttributesRequestData RequestData) : base(RequestData)
        {

        }
    }
}