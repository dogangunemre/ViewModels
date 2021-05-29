using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewCategoriesResponseViewModel : ResponseViewModel<AddNewCategoriesRequestData, AddNewCategoriesResponseData>
    {
        public AddNewCategoriesResponseViewModel() : base()
        {

        }
        public AddNewCategoriesResponseViewModel(AddNewCategoriesRequestData RequestData) : base(RequestData)
        {

        }
    }
}