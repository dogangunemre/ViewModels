using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class ChangeCargoServicePriceConstraintResponseViewModel: ResponseViewModel<ChangeCargoServicePriceConstraintRequestData, ChangeCargoServicePriceConstraintResponseData>
    {
        public ChangeCargoServicePriceConstraintResponseViewModel() : base()
        {

        }
        public ChangeCargoServicePriceConstraintResponseViewModel(ChangeCargoServicePriceConstraintRequestData RequestData) : base(RequestData)
        {

        }

    }
}