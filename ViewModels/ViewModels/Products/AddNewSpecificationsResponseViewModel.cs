using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewSpecificationsResponseViewModel : ResponseViewModel<AddNewSpecificationsRequestData, AddNewSpecificationsResponseData>
    {
        public AddNewSpecificationsResponseViewModel() : base()
        {

        }
        public AddNewSpecificationsResponseViewModel(AddNewSpecificationsRequestData RequestData) : base(RequestData)
        {

        }
    }
}