using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewDiscountsResponseViewModel : ResponseViewModel<AddNewDiscountsRequestData, AddNewDiscountsResponseData>
    {
        public AddNewDiscountsResponseViewModel() : base()
        {

        }
        public AddNewDiscountsResponseViewModel(AddNewDiscountsRequestData RequestData) : base(RequestData)
        {

        }
    }
}