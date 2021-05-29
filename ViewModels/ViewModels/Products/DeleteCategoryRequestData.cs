using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteCategoryRequestData : IRequestData
    {
        public string CategoryID { get; set; }

    }
}