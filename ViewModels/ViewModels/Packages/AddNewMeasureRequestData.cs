using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewMeasureRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public MeasureList Measures { get; set; }
    }
}