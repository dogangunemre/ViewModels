using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class GetByBarcodeResponseData : IResponseData
    {
        public IProductBarcode Barcode { get; set; }

    }
}