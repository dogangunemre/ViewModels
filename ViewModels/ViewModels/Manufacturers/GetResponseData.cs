using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Manufacturers
{
    public class GetResponseData : IResponseData
    {
        public ManufacturerBasic Manufacturer { get; set; }
    }
}