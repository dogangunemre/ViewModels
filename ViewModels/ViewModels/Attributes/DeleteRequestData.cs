using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Attributes
{
    public class DeleteRequestData:IRequestData
    {
        public string AttributeID { get; set; }
    }
}