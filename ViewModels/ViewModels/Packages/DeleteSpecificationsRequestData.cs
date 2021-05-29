using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class DeleteSpecificationsRequestData:IRequestData
    {
        public string SpecificationID { get; set; }

    }
}