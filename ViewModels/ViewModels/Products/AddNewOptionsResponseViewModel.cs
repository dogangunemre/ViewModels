using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewOptionsResponseViewModel : ResponseViewModel<AddNewOptionsRequestData, AddNewOptionsResponseData>
    {
        public AddNewOptionsResponseViewModel() : base()
        {

        }
        public AddNewOptionsResponseViewModel(AddNewOptionsRequestData RequestData) : base(RequestData)
        {

        }
    }
}