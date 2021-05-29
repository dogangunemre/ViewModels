using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Properties;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Orders
{
    public class ChangeItemAmountRequestData:IRequestData
    {
        public string OrderID { get; set; }
        public ProductBasic Item { get; set; }

        public int Amount { get; set; }

    }
}