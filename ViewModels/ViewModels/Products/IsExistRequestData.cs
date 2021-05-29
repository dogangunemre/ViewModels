using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class IsExistRequestData : IRequestData
    {
        public string ProductID { get; set; }
    }
}