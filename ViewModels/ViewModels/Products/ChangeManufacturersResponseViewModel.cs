using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ChangeManufacturersResponseViewModel : ResponseViewModel<ChangeManufacturersRequestData, ChangeManufacturersResponseData>
    {
        public ChangeManufacturersResponseViewModel() : base()
        {

        }
        public ChangeManufacturersResponseViewModel(ChangeManufacturersRequestData RequestData) : base(RequestData)
        {

        }

    }
}