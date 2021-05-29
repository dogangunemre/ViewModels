using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class ChangeCargoServicePriceConstraintResponseData : IResponseData
    {
        public PriceBasic Price { get; set; }


    }
}