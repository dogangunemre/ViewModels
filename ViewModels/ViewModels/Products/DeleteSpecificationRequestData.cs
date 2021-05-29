using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteSpecificationRequestData : IRequestData
    {
        public string SpecificationID { get; set; }

    }
}