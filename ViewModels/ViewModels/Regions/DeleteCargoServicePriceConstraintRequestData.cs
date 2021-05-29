using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class DeleteCargoServicePriceConstraintRequestData : IRequestData
    {
        public string CargoID { get; set; }
        public string RegionID { get; set; }
        public string PriceID { get; set; }
        public string Constraint { get; set; }
    }
}