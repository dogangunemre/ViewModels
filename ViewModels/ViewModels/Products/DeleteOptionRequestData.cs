using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteOptionRequestData : IRequestData
    {
        public string OptionsID { get; set; }

    }
}