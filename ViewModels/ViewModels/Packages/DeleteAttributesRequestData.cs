using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteAttributesRequestData:IRequestData
    {
        public string AttributeID { get; set; }
    }
}