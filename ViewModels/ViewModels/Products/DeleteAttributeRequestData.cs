using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteAttributeRequestData : IRequestData
    {
        public string AttributeID { get; set; }

    }
}