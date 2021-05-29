using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewAttributesRequestData:IRequestData
    {
        public string PackageID { get; set; }
        public AttributeList Attributes { get; set; }
    }
}