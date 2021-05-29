using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class ChangeCargoServicePriceConstraintRequestData : IRequestData
    {
        public string CargoID { get; set; }
        public string RegionID { get; set; }
        public string PriceID { get; set; }
        public string Constraint { get; set; }
    }
}