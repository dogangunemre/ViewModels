using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class AddNewCargoServicePriceConstraintResponseViewModel : ResponseViewModel<AddNewCargoServicePriceConstraintRequestData, AddNewCargoServicePriceConstraintResponseData>
    {
        public AddNewCargoServicePriceConstraintResponseViewModel() : base()
        {

        }
        public AddNewCargoServicePriceConstraintResponseViewModel(AddNewCargoServicePriceConstraintRequestData RequestData) : base(RequestData)
        {

        }
    }
}