using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class GetByBarcodeRequestData : IRequestData
    {
        public string BarcodeID { get; set; }

    }
}